import { Stack } from "@chakra-ui/react";
import ListingEntry from "./listing-entry";

export default function ExploreListings({listings} : ExploreListingProps){

    return (
        <>
        <Stack w="100%">
            {listings.map((item, index) => (
                <ListingEntry props={item.props} />
            ))}
        </Stack>
        </>
    );
}