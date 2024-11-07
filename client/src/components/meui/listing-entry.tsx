import { useFetchData } from "@/hooks/use-fetch-data";
import { Box, Card, Heading, Image } from "@chakra-ui/react";

export default function ListingEntry({props} : ListingEntryProps){
    const carData = useFetchData('/store/carData.json');

    props.mode = "standard";
    switch (props.mode) {
        case "standard":
            return(
                <StandardListing props={props} carProps={carData}/>
            );
        case "superlong":
            return(
                <SuperLongListing/>
            );
        case "long":
            return(
                <LongListing/>
            );
        case "short":
            return(
                <ShortListing/>
            );
        default:
            return(
                <StandardListing props={props} carProps={carData}/>
            );
    }
}

function SuperLongListing(){
    return (
        <>
        </>
    );
}

function LongListing(){
    return (
        <>
        </>
    );
}

function StandardListing({props, carProps} : InnerListingEntryProps){
    return (
        <>
            <Card.Root flexDir="row" overflow="hidden" w="100%" maxW="3xl" h="100px" variant="subtle">
                <Image
                    objectFit="cover"
                    maxW="100px"
                    src="/mainBg.jpg"
                />
                <Box>
                    <Heading>{props.title}</Heading>
                    <Heading>{carProps?.brand}</Heading>
                    <Card.Body>
                    
                    </Card.Body>
                    <Card.Footer>

                    </Card.Footer>
                </Box>
            </Card.Root>
        </>
    );
}

function ShortListing(){
    return (
        <>
        </>
    );
}

function BaseListing({} : BaseListingProps){
    return (
        <>
        </>
    );
}