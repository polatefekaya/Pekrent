import { Box, Button, Center, Flex, Grid, Heading, Highlight, Image, Link, Stack, Text, Theme } from "@chakra-ui/react";
import styles from "./page.module.css";
import { BiPen, BiPencil } from "react-icons/bi";
import { redirect } from "next/navigation";

export default function Home() {
  return (
    <>
      <div style={{height: "100dvh"}}>
       <Box
        w="100%"
        h="100dvh"
        bgImage={"url('wBG3.jpg')"}
        bgPos="center"
        bgRepeat="no-repeat"
        bgSize={{base: 'cover'}}
        paddingTop={{base: "5rem", md: "10rem"}}
       >
        <Heading textStyle="7xl" fontWeight="bold" textAlign="center">pekrent</Heading>
        <Heading textStyle="3xl" as="h2" textAlign="center" marginTop="1.5rem">
          <Highlight query="redefined." styles={{color: "fg.success", bg: "green.subtle"}}>Global car renting redefined.</Highlight>
        </Heading>
        <Center>
          <Box maxW="80%">
            <Stack paddingTop="40dvh" maxW={"100%"}>
            <Heading as="h3">We think renting a car for your trip should be easy</Heading>
            <Heading as="h5" textStyle="lg"><Highlight query="pekrent" styles={{fontWeight: "bold"}}>So we made pekrent to overcome this.</Highlight></Heading>
            </Stack>
          </Box>
        </Center>
        <Center>
          <Stack direction="row" paddingTop={{base: "2dvh", md: "4dvh"}} gap="3rem" w={{base: "21rem", sm: "22rem", md: "25rem", lg: "27rem", xl: "29rem"}}>
            <Box>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">Individuals to individuals</Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">Trustworthy experience</Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">With no hidden fees</Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">People just want to go out</Heading>
            </Box>
            <Stack direction="column" ml="auto">
              <Link href="/register">
                  <Button size={{base: "sm", md: "md"}} w="6rem" colorPalette="white" appearance="light">
                    Register
                  </Button>
              </Link>
              <Link href="/login">
                  <Button size={{base: "sm", md: "md"}} w="6rem" colorPalette="white" appearance="light" variant="surface">
                    Login
                  </Button>
              </Link>
            </Stack>
          </Stack>
        </Center>
       </Box>
      </div>
    </>
  );
}
