import { useFetchData } from "@/hooks/use-fetch-data";
import { Box, Card, Center, Flex, Heading, Image, Link, Separator, Text } from "@chakra-ui/react";
import { BrandDetails, CarDetails, Price, UserDetails } from "./listing-entry-helper";

export default function ListingEntry({props} : ListingEntryProps){
    const carData = useFetchData('/store/carData.json');
    const userData = useFetchData('/store/userData.json');

    props.mode = "standard";
    switch (props.mode) {
        case "standard":
            return(
                <StandardListing props={props} carProps={carData} userProps={userData}/>
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
                <StandardListing props={props} carProps={carData} userProps={userData}/>
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

function StandardListing({props, carProps, userProps} : InnerListingEntryProps){
    return (
        <>
                <Link>
            <Card.Root flexDir="row" overflow="hidden" w="100%" maxW="4xl" h="130px" variant="subtle">
                <Image
                    objectFit="cover"
                    maxW="120px"
                    src="/mainBg.jpg"
                />
                <Box p="0.5rem" w="40%">

                    <Card.Title mb="1rem">
                    <Heading textStyle="lg">{props.title}</Heading>
                    
                    <BrandDetails carProps={carProps}/>
                    </Card.Title>
                    <Card.Body>
                        <Flex alignItems="flex-end">
                        <Box mt="auto">

                        <Price props={props}/>
                        </Box>
                        </Flex>
                    </Card.Body>
                    <Card.Footer>

                    </Card.Footer>
                </Box>
                <Center ml="0.5rem" mr="0.7rem">
                    <Separator orientation="vertical" height="75%" />
                </Center>
                <Center minW={{base:"30%", md: "25%"}}>
                <Box w="100%">
                    <Center>
                    <CarDetails carProps={carProps}/>
                    </Center>
                </Box>
                </Center>
                <Center ml="0.5rem" mr="0.5rem">
                    <Separator orientation="vertical" height="75%" />
                </Center>
                <Center>
                    <UserDetails props={userProps!}/>
                </Center>
                
            </Card.Root>
                </Link>
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