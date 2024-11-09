import { create } from "zustand";

const useFilterStoreV2 = create<FilterStateV2>((set, get) => ({
  filters: {
    trunkcapacity: new Map(),
    usecase: new Map(),
    gearbox: new Map(),
    drivetrain: new Map(),
    seats: new Map(),
    acceleration: new Map(),
    fuelcapacity: new Map(),
    fueltype: new Map(),
    range: new Map(),
    body: new Map(),
    topspeed: new Map(),
    horsepower: new Map(),
    fuelconsumptioncity: new Map(),
    fuelconsumption: new Map(),
    torque: new Map(),
    doors: new Map(),
    year: new Map(),
    brand: new Map(),
    model: new Map(),
  },

  initializeFilterGroup: (groupName, mode, length, range) => {
    set((state) => {
      const initialMap = new Map<number, FilterOption>();
      console.log("GroupName: ", groupName);
      console.log("Mode: ", mode);
      console.log("Length: ", length);
      console.log("Range: ", range);

      if (mode === "boolean" && length) {
        for (let i = 0; i < length; i++) {
          initialMap.set(i, {
            type: mode,
            value: false, // Set initial value based on the mode
          });
        }
      } else if (mode === "range" && range) {
        initialMap.set(0, {
          type: mode,
          value: range, // using 0 as range and 1 as selectedRange
        });
        initialMap.set(1, {
          type: mode,
          value: range, // using 0 as range and 1 as selectedRange
        });
        console.log("Setted Range: ", initialMap.get(0)?.value);
      }
      return {
        filters: {
          ...state.filters,
          [groupName]: initialMap,
        },
      };
    });
  },

  updateFilterOption: (groupName, index, value, mode) => {
    set((state) => {
      const updatedMap = new Map(state.filters[groupName]);
      const currentOption = updatedMap.get(index);

      if (mode === "boolean" && currentOption) {
        updatedMap.set(index, { ...currentOption, value });
      } else if (mode === "range" && currentOption) {
        updatedMap.set(1, { ...currentOption, value });
      }

      return {
        filters: {
          ...state.filters,
          [groupName]: updatedMap,
        },
      };
    });
  },

  getFiltersAsJSON: () => {
    const filtersState = get().filters;
    const serializedFilters = Object.fromEntries(
      Object.entries(filtersState).map(([key, map]) => [
        key,
        Object.fromEntries(
          Array.from(map.entries()).map(
            ([index, option]: [number, FilterOption]) => [index, option]
          )
        ),
      ])
    );
    return JSON.stringify(serializedFilters);
  },
}));

export default useFilterStoreV2;
