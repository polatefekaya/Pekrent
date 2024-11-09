import { Box, Center, Spinner } from "@chakra-ui/react";

export function LoadingFallbackABS(){
    return(
        <>
        <Box position="absolute" w="100vw" h="100dvh" zIndex="100">
            <Center>
                <Box mt="40dvh" p="0.7rem" pb="0.4rem" rounded="md" backgroundColor="gray.100">
                    <Spinner size="xl"/>
                </Box>
            </Center>
        </Box>
        </>
    );
}

export function LoadingFallback(){
    return(
        <>
            <Box ml="40%" zIndex="100">
                <Center>
                    <Box mt="40dvh" p="0.7rem" pb="0.4rem" rounded="md" backgroundColor="gray.100">
                        <Spinner size="xl"/>
                    </Box>
                </Center>
            </Box>
        
        </>
    );
}