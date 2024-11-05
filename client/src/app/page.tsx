"use client"
import { Box, Button, Center, Flex, Grid, Heading, Highlight, Icon, Image, Link, Stack, Tabs, Text, Theme } from "@chakra-ui/react";
import styles from "./page.module.css";
import { BiArrowToBottom, BiPen, BiPencil } from "react-icons/bi";
import { redirect } from "next/navigation";
import { BsArrowDownShort } from "react-icons/bs";
import { useState } from "react";
import { Blockquote } from "@/components/ui/blockquote";

export default function Home() {
  const [howItWorksWord, setHowItWorksWord] = useState("Renting");
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
        paddingTop={{base: "5.5rem",sm: "6rem", md: "6rem", lg: "6rem", xl:"6rem"}}
       >
        <Heading textStyle="7xl" fontWeight="bold" textAlign="center">pekrent</Heading>
        <Heading textStyle="3xl" as="h2" textAlign="center" marginTop="1.5rem">
          <Highlight query="redefined." styles={{color: "fg.success", bg: "green.subtle"}}>Global car renting redefined.</Highlight>
        </Heading>
        <Center>
          <Box maxW="80%">
            <Stack paddingTop={{base: "45dvh",sm: "50dvh", md: "50dvh", lg: "50dvh", xl:"50dvh"}} maxW={"100%"}>
            <Heading as="h3">Connect with car owners near you for affordable and convenient rentals on demand.</Heading>
            </Stack>
            <Center>
                <Icon textStyle="5xl" color="blackAlpha.800" marginTop={{base: "0.5rem", sm: "1.2rem", md: "2rem", lg: "3.5rem", xl: "4rem"}}>
                  <BsArrowDownShort/>
                </Icon>
            </Center>
          </Box>
        </Center>
        
       </Box>
      </div>
        <Center>
          <Box mt="5rem" w="3xl" maxW="90%">
            <Blockquote></Blockquote>
            <Heading as="h5" textStyle="lg" fontWeight="normal"><Highlight query="pekrent" styles={{fontWeight: "bold"}}>Whether you’re looking for a quick trip around the city or a weekend escape, Pekrent connects you with trusted car owners to get you on the road fast.</Highlight></Heading>
          </Box>
        </Center>
        <Center>
          <Box w="3xl" mt="5rem">
            <Heading>Makes {howItWorksWord} Easy</Heading>
              <Tabs.Root defaultValue="rent" variant="enclosed" colorPalette="fg">

                    <Tabs.List padding="0.35rem" height="2.75rem">
                  <Center>
                    <Text textStyle="lg" marginRight="1rem" marginLeft="0.5rem">I want to</Text>
                      <Tabs.Trigger value="rent" height="2rem" paddingLeft="0.5rem" paddingRight="0.5rem" onClick={(e) => setHowItWorksWord("Renting")}>
                        Rent a Car
                      </Tabs.Trigger>
                      <Tabs.Trigger value="list" height="2rem" paddingLeft="0.5rem" paddingRight="0.5rem" onClick={(e) => setHowItWorksWord("Listing")}>
                        List My Car
                      </Tabs.Trigger>

                      <Tabs.Indicator rounded="l2"/>
                  </Center>
                    </Tabs.List>


                <Tabs.Content value="rent">
                  RTENTETEGT
                </Tabs.Content>
                <Tabs.Content value="list">
                  LISLITLSIT
                </Tabs.Content>
              </Tabs.Root>
          </Box>
        </Center>
      <Center>
      <Box maxW="3xl">
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
      </Box>
        </Center>
    </>
  );
}
