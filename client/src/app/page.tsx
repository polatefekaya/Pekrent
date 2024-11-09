"use client";
import {
  Box,
  Button,
  Card,
  Center,
  Flex,
  Grid,
  Heading,
  Highlight,
  Icon,
  Image,
  Link,
  Mark,
  Separator,
  Stack,
  Tabs,
  Text,
  Theme,
} from "@chakra-ui/react";
import styles from "./page.module.css";
import { BiArrowToBottom, BiChat, BiHappy, BiListCheck, BiMoney, BiPen, BiPencil, BiSearch } from "react-icons/bi";
import { redirect } from "next/navigation";
import { BsArrowDownShort } from "react-icons/bs";
import { useState } from "react";
import { Blockquote } from "@/components/ui/blockquote";
import LandingCard from "@/components/meui/landing-card";
import { GiConfirmed } from "react-icons/gi";

export default function Home() {
  const [howItWorksWord, setHowItWorksWord] = useState("Renting");
  return (
    <>
      <div style={{ height: "100dvh" }}>
        <Box
          w="100%"
          h="100dvh"
          bgImage={"url('wBG3.jpg')"}
          bgPos="center"
          bgRepeat="no-repeat"
          bgSize={{ base: "cover" }}
          paddingTop={{
            base: "5.5rem",
            sm: "6rem",
            md: "6rem",
            lg: "6rem",
            xl: "6rem",
          }}
        >
          <Heading textStyle="7xl" fontWeight="bold" textAlign="center">
            pekrent
          </Heading>
          <Heading
            textStyle="3xl"
            as="h2"
            textAlign="center"
            marginTop="1.5rem"
          >
            <Highlight
              query="redefined."
              styles={{ color: "fg.success", bg: "green.subtle" }}
            >
              Global car renting redefined.
            </Highlight>
          </Heading>
          <Center>
            <Box maxW="80%">
              <Stack
                paddingTop={{
                  base: "45dvh",
                  sm: "50dvh",
                  md: "50dvh",
                  lg: "50dvh",
                  xl: "50dvh",
                }}
                maxW={"100%"}
              >
                <Heading as="h3">
                  Connect with car owners near you for affordable and convenient
                  rentals on demand.
                </Heading>
              </Stack>
              <Center>
                <Icon
                  textStyle="5xl"
                  color="blackAlpha.800"
                  marginTop={{
                    base: "0.5rem",
                    sm: "1.2rem",
                    md: "2rem",
                    lg: "3.5rem",
                    xl: "4rem",
                  }}
                >
                  <BsArrowDownShort />
                </Icon>
              </Center>
            </Box>
          </Center>
        </Box>
      </div>
      <Center>
        <Box mt={{ base: "3rem", md: "4rem" }} w="3xl" maxW="90%">
          <Blockquote
            showDash
            colorPalette="green"
            textStyle={{ base: "md", md: "xl" }}
            paddingLeft="1rem"
            cite="CEO - Polat E. K."
          >
            Whether you’re looking for a quick trip around the city or a weekend
            escape, Pekrent connects you with trusted car owners to get you on
            the road fast.
          </Blockquote>
        </Box>
      </Center>
      <Center>
        <Box w="3xl" mt={{ base: "2rem", md: "4rem" }} maxW="90%">
          <Heading textStyle="3xl">
            <Highlight
              query={["Renting", "Listing"]}
              styles={{ color: "green.solid" }}
            >
              {`Makes ${howItWorksWord} Super Easy`}
            </Highlight>
          </Heading>
          <Tabs.Root mt="1rem" defaultValue="rent" variant="enclosed" colorPalette="fg">
            <Tabs.List padding="0.35rem" height="2.75rem" roundedBottom="0">
              <Center>
                <Text textStyle="lg" marginRight="1rem" marginLeft="0.5rem">
                  I want to
                </Text>
                <Tabs.Trigger
                  value="rent"
                  height="2rem"
                  paddingLeft="0.5rem"
                  paddingRight="0.5rem"
                  onClick={(e) => setHowItWorksWord("Renting")}
                  mr="0.5rem"
                >
                  Rent a Car
                </Tabs.Trigger>
                <Tabs.Trigger
                  value="list"
                  height="2rem"
                  paddingLeft="0.5rem"
                  paddingRight="0.5rem"
                  onClick={(e) => setHowItWorksWord("Listing")}
                >
                  List My Car
                </Tabs.Trigger>

                <Tabs.Indicator rounded="l2"/>
              </Center>
            </Tabs.List>
            <Separator size="lg" colorPalette="green" mb="2rem"/>

            <Tabs.Content value="rent">
              <Box>
                  <Center>
                    <Stack gap="5">
                      <LandingCard 
                        title="Browse Listings"
                        description="Discover a variety of cars owned by locals, each available for rental at a price that suits your budget. Use our search filters to quickly find options by location, car type, and other features. With detailed car profiles and user reviews, you can make an informed choice and find the perfect vehicle for your trip."
                        iconNode={<BiSearch/>}
                      />
                      <LandingCard 
                        title="Connect and Confirm Booking"
                        description="Once you find a car you like, message the owner directly to discuss availability and confirm details. Pekrent’s secure chat system makes communication easy, so you can feel confident in your rental choice. When you’re ready, simply confirm your booking with a few taps."
                        iconNode={<BiChat/>}
                      />
                      <LandingCard 
                        title="Pick Up and Hit the Road"
                        description="On your rental day, meet the car owner at the designated location, pick up the keys, and start your journey. Enjoy your rental with full insurance and roadside support, so you can focus on the road ahead with peace of mind."
                        iconNode={<BiHappy/>}
                      />
                    </Stack>
                  </Center>
              </Box>
            </Tabs.Content>
            <Tabs.Content value="list">
            <Box>
                  <Center>
                    <Stack gap="5">
                      <LandingCard 
                        title="Set Up Your Listing"
                        description="Easily create a listing for your car by adding photos, setting your price, and providing availability details. With a few steps, your car will be ready for renters to find. Sharing your car on Pekrent is a great way to earn extra income while helping others travel conveniently."
                        iconNode={<BiListCheck/>}
                      />
                      <LandingCard 
                        title="Connect with Renters"
                        description="Review booking requests as they come in, and chat with potential renters through Pekrent’s secure messaging to answer any questions. Confirm the booking once you’re comfortable with the arrangement, knowing that you have control over who rents your vehicle."
                        iconNode={<BiChat/>}
                      />
                      <LandingCard 
                        title="Earn Money and Share Your Car"
                        description="Hand over the keys on pickup day and earn income from your rental. All rentals are insured, so you can share your car confidently. You’ll receive your earnings securely through Pekrent, helping you turn your car into a valuable asset."
                        iconNode={<BiMoney/>}
                      />
                    </Stack>
                  </Center>
              </Box>
            </Tabs.Content>
          </Tabs.Root>
        </Box>
      </Center>
      <Center>
        <Box maxW="3xl">
          <Stack
            direction="row"
            paddingTop={{ base: "2dvh", md: "4dvh" }}
            gap="3rem"
            w={{
              base: "21rem",
              sm: "22rem",
              md: "25rem",
              lg: "27rem",
              xl: "29rem",
            }}
          >
            <Box>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">
                Individuals to individuals
              </Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">
                Trustworthy experience
              </Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">
                With no hidden fees
              </Heading>
              <Heading textStyle="sm" textAlign="left" fontWeight="normal">
                People just want to go out
              </Heading>
            </Box>
            <Stack direction="column" ml="auto">
              <Link href="/register">
                <Button
                  size={{ base: "sm", md: "md" }}
                  w="6rem"
                  colorPalette="white"
                  appearance="light"
                >
                  Register
                </Button>
              </Link>
              <Link href="/login">
                <Button
                  size={{ base: "sm", md: "md" }}
                  w="6rem"
                  colorPalette="white"
                  appearance="light"
                  variant="surface"
                >
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
