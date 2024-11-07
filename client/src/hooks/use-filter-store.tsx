import { create } from "zustand";

const useFilterStore = create<FilterState>((set, get) => ({
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

  initializeFilterGroup: (groupName, length) => {
    set((state) => {
      const initialMap = new Map<number, boolean>();
      console.log("GroupName: ", groupName);
      console.log("Length: ", length);

      if (length) {
        for (let i = 0; i < length; i++) {
          initialMap.set(i, false);
        }
      }
      return {
        filters: {
          ...state.filters,
          [groupName]: initialMap,
        },
      };
    });
  },

  updateFilterOption: (groupName, index, value) => {
    set((state) => {
      const updatedMap = new Map(state.filters[groupName]);

      updatedMap.set(index, value);
      
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
            ([index, option]: [number, boolean]) => [index, option]
          )
        ),
      ])
    );
    return JSON.stringify(serializedFilters);
  },
}));

export default useFilterStore;
