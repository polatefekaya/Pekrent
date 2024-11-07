"use client"

import ExploreFilters from "@/components/meui/explore-filters";
import ExploreListings from "@/components/meui/explore-listings";
import { useFetchData } from "@/hooks/use-fetch-data";
import { Box, Center, Stack } from "@chakra-ui/react";
import { Suspense, useState } from "react";

export default function Explore() {
    console.log("before usefetchdata");
    const filterData = useFetchData('/store/filterData.json');
    const listingData = useFetchData('/store/entryData.json');
    console.log("after usefetchdata");
    //const [filterData, setFilterData] = useState([]);
  return (
    <>
    <Suspense>
        <Center>
        <Box w="5xl">
            <Box>
                <Center>

                </Center>
            </Box>
            <Stack direction="row" pt="2rem">   
                <ExploreFilters areas={filterData}/>
                <ExploreListings listings={listingData}/>
            </Stack>
        </Box>
        </Center>
    </Suspense>
    </>
  );
}
