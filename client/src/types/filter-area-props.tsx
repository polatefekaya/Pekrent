type FilterAreaPropsV2 = {
  title: string;
  lines?: FilterLineProps[];
  range?: [number, number];
  selectedRange?: [number, number];
  groupName: string;
  mode: "boolean" | "range";
};

type FilterAreaProps = {
  title: string;
  lines?: FilterLineProps[];
  groupName: string;
};

type FilterLineProps = {
  label: string;
};
