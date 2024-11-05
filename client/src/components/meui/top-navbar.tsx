import { Box, Button, Center, Heading, Stack, Theme } from "@chakra-ui/react";

export default function TopNavigationBar({authenticated = false, mode="", page=""} : TopNavbarProps){
    return (
        <>
        <Theme appearance="light">
            <Box backgroundColor="colorPalette.200">
                <Heading pos="absolute">pekrent</Heading>
                <Center>
                    <Stack>
                        <Button variant="surface">Home</Button>
                    </Stack>
                </Center>
            </Box>
        </Theme>
        </>
    );
}