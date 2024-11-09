"use client"

import ExploreFilters from "@/components/meui/explore-filters";
import ExploreListings from "@/components/meui/explore-listings";
import {LoadingFallback, LoadingFallbackABS} from "@/components/meui/loading-fallback";
import { useFetchData } from "@/hooks/use-fetch-data";
import { Box, Center, Spinner, Stack } from "@chakra-ui/react";
import { Suspense, useState } from "react";

export default function Explore() {

  return (
    <>
    
        <Center>
        <Box w="5xl" maxW="95%">
            <Box>
                <Center>

                </Center>
            </Box>
            <Stack direction="row" pt="2rem">  
                <Suspense fallback={<LoadingFallback/>}>
                    <Filters/>
                </Suspense> 
                <Suspense fallback={<LoadingFallback/>}>
                    <Listings />

                </Suspense>
            </Stack>
        </Box>
        </Center>
    
    </>
  );
}

function Filters() {
    const filterData = useFetchData('/store/filterData.json');
    if (!filterData) return null;
    return <ExploreFilters areas={filterData} />;
  }
  
  function Listings() {
    const listingData = useFetchData('/store/entryData.json');
    if (!listingData) return null;
    return <ExploreListings listings={listingData} />;
  }