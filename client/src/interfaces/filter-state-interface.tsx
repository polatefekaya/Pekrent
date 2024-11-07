interface FilterOption {
  type: "boolean" | "range"; // Filter types: boolean or range
  value: boolean | [number, number]; // Value can be a boolean or a range [min, max]
}

interface FilterStateV2 {
  filters: {
    [key: string]: Map<number, FilterOption>;
  };
  initializeFilterGroup: (
    groupName: string,
    mode: "boolean" | "range",
    length?: number,
    range?: [number, number],
    selectedRange?: [number, number]
  ) => void;
  updateFilterOption: (
    groupName: string,
    index: number,
    value: boolean | [number, number],
    mode?: string
  ) => void;
  getFiltersAsJSON: () => string; // Method to get filters as JSON
}

interface FilterState {
  filters: {
    [key: string]: Map<number, boolean>;
  };
  initializeFilterGroup: (groupName: string, length?: number) => void;
  updateFilterOption: (
    groupName: string,
    index: number,
    value: boolean
  ) => void;
  getFiltersAsJSON: () => string; // Method to get filters as JSON
}
