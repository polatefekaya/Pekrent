import { Skeleton } from "@/components/ui/skeleton";
import { Box, Center, Heading, HStack, Stack } from "@chakra-ui/react";

export default function ExploreLoading() {
  return (
    <>
        <Center>
      <Box w="5xl" maxW="90%" mt="5rem">
            <Stack w="100%" gap="1.5rem">
                <Box w="100%">
                    <Skeleton height="200px"/>
                </Box>
                <HStack  w="100%" gap="2%">
                    <Skeleton height="400px" w="29%"/>
                    <Skeleton height="400px" w="69%"/>
                </HStack>
            </Stack>
      </Box>
        </Center>
    </>
  );
}
