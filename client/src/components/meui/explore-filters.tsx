"use client";
import {
  Box,
  Card,
  Center,
  CheckboxGroup,
  Fieldset,
  Heading,
  HStack,
  Separator,
  Stack,
  Text,
} from "@chakra-ui/react";
import { Checkbox } from "../ui/checkbox";
import { useEffect, useState } from "react";
import useFilterStoreV2 from "@/hooks/use-filter-store-v2";
import { Slider } from "../ui/slider";
import useFilterStore from "@/hooks/use-filter-store";

export default function ExploreFilters({ areas }: ExploreFilterProps) {
  return (
    <>
      <Card.Root
        backgroundColor="gray.subtle"
        variant="elevated"
        p="0.5rem"
        w="200px"
      >
        <Card.Body gap="3">
          {areas.map((item, _) => (
            <FilterAreaBasic
              lines={item.lines}
              title={item.title}
              groupName={item.groupName}
            />
          ))}
        </Card.Body>
      </Card.Root>
    </>
  );
}

function FilterAreaBasic({ title, lines, groupName }: FilterAreaProps) {
  const { filters, initializeFilterGroup, updateFilterOption } =
    useFilterStore();

  useEffect(() => {
    if (!lines) return;
    initializeFilterGroup(groupName, lines.length);
  }, [initializeFilterGroup, groupName, lines]);

  const checkedMap = filters[groupName] || new Map();

  return (
    <>
      <Box>
        <Heading textStyle="md">{title}</Heading>
        <Card.Root variant="outline" maxH="100px" overflowY="auto" p="0.5rem">
          <Card.Body>
            <Fieldset.Root>
              <CheckboxGroup>
                <Fieldset.Content>
                  <Stack dir="row" gap="2">
                    {lines!.map((line, index) => (
                      
                        <Checkbox
                          key={index}
                          checked={!!checkedMap.get(index)}
                          onChange={(e) =>
                            updateFilterOption(
                              groupName,
                              index,
                              (e.target as HTMLInputElement).checked
                            )
                          }
                        >
                          {line.label}
                        </Checkbox>
                      )
                    )}
                  </Stack>
                </Fieldset.Content>
              </CheckboxGroup>
            </Fieldset.Root>
          </Card.Body>
        </Card.Root>
      </Box>
    </>
  );
}

// function FilterArea({
//   title,
//   lines,
//   range,
//   groupName,
//   mode,
// }: FilterAreaPropsV2) {
//   const { filters, initializeFilterGroup, updateFilterOption } =
//     useFilterStoreV2();
//   const [rangeVal, setRangeVal] = useState([0, 0]);

//   const handleSliderValue = (e: any) => {
//     updateFilterOption(groupName, 1, [e.value[0], e.value[1]]);
//     setRangeVal(e.value);
//   };

//   let checkedMap = filters[groupName] || new Map();
//   useEffect(() => {
//     //if(lines === undefined) return;

//     if (mode === "boolean" && lines) {
//       initializeFilterGroup(groupName, mode, lines.length, undefined);
//     } else if (mode === "range" && range) {
//       initializeFilterGroup(groupName, mode, undefined, range);
//     }

//     checkedMap = filters[groupName];
//   }, [initializeFilterGroup, groupName, lines]);

//   if (mode === "range" && checkedMap.get(0)?.value != undefined) {
//     console.log("RANGEVAL: ", checkedMap.get(0)?.value);
//     console.log("MODE: ", checkedMap.get(0)?.type);
//   }
//   return (
//     <>
//       <Box>
//         <Heading textStyle="md">{title}</Heading>
//         <Card.Root variant="outline" maxH="100px" overflowY="auto" p="0.5rem">
//           <Card.Body>
//             {mode === "boolean" ? (
//               <Fieldset.Root>
//                 <CheckboxGroup>
//                   <Fieldset.Content>
//                     <Stack dir="row" gap="2">
//                       {lines!.map((line, index) => {
//                         const filterOption = checkedMap.get(index);
//                         const isChecked =
//                           filterOption && filterOption.type === "boolean"
//                             ? (filterOption.value as boolean)
//                             : false;

//                         return (
//                           <Checkbox
//                             key={index}
//                             checked={isChecked}
//                             onChange={(e) =>
//                               updateFilterOption(
//                                 groupName,
//                                 index,
//                                 (e.target as HTMLInputElement).checked
//                               )
//                             }
//                           >
//                             {line.label}
//                           </Checkbox>
//                         );
//                       })}
//                     </Stack>
//                   </Fieldset.Content>
//                 </CheckboxGroup>
//               </Fieldset.Root>
//             ) : (
//               <Box>
//                 <Box>
//                   <Center>
//                     <HStack pl="10px" pr="5px">
//                       <Text textStyle="lg">
//                         {checkedMap.get(1)?.value[0]} to{" "}
//                         {checkedMap.get(1)?.value[1]}
//                       </Text>
//                       <Separator
//                         orientation="vertical"
//                         height="4"
//                         size="md"
//                         ml="20px"
//                         mr="7px"
//                       />
//                       <Text textStyle="sm" color="blackAlpha.500">
//                         {checkedMap.get(0)?.value[0]} -{" "}
//                         {checkedMap.get(0)?.value[1]}
//                       </Text>
//                     </HStack>
//                   </Center>
//                 </Box>
//                 <Slider
//                   defaultValue={range}
//                   value={rangeVal}
//                   onValueChange={handleSliderValue}
//                   min={checkedMap.get(0)?.value[0]}
//                   max={checkedMap.get(0)?.value[1]}
//                 />
//               </Box>
//             )}
//           </Card.Body>
//         </Card.Root>
//       </Box>
//     </>
//   );
// }
