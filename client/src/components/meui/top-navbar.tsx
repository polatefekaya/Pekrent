"use client";

import {
  Box,
  Button,
  Center,
  Flex,
  Heading,
  HStack,
  Link,
  Separator,
  Stack,
  Text,
  Theme,
  useBreakpointValue,
} from "@chakra-ui/react";
import { BiArrowToRight, BiMenu, BiPlus } from "react-icons/bi";
import { Avatar } from "../ui/avatar";
import NavigationTabs from "./nav-tabs";
import { BsArrowLeft, BsArrowRight, BsArrowRightShort } from "react-icons/bs";
import NavbarDrawer from "./drawer-navbar";

export default function TopNavigationBar({
  authenticated = false,
  mode = "",
  page = "",
}: TopNavbarProps) {
  const isMobile = useBreakpointValue({ base: true, lg: false });

  const handleDrawer = () => {};

  return (
    <>
      <Box backgroundColor="white" h="60px">
        <Flex h="100%" gap={4} justify="space-between" pl="1rem" pr="1rem">
          {isMobile && (
            <Center>
              <Box h="100%">
                <Center h="100%">
                    <NavbarDrawer handleDrawer={handleDrawer}/>
                  {/* <Button
                    variant="subtle"
                    pr="0.3rem"
                    pl="0.3rem"
                    h="45px"
                    width="45px"
                    onClick={() => {
                      handleDrawer();
                    }}
                  >
                    <BiMenu size="22px" />
                  </Button> */}
                </Center>
              </Box>
            </Center>
          )}
          {/* brand */}
            <Center
                marginEnd={isMobile ? "0" : "auto"}
                marginStart={isMobile ? "auto" : "0"}
            >
                <Box>
                <Link href="/">
                    <Heading>pekrent</Heading>
                </Link>
                </Box>
            </Center>

          {/* nav */}
          <Center marginStart={isMobile ? "auto" : "0"}>
            <Box>
              <Center>
                <NavigationTabs
                  selected={page}
                  authenticated={authenticated}
                  mode="general"
                />
              </Center>
            </Box>
          </Center>
          {authenticated ? (
            <>
              {!isMobile && (
                <Center marginStart="auto">
                  <Box>
                    <NavigationTabs
                      selected={page}
                      authenticated={authenticated}
                      mode="yourtabs"
                    />
                  </Box>
                </Center>
              )}
              {!isMobile && (
                <Center>
                  <Box h="100%">
                    <Center h="100%">
                      <Button variant="subtle" pr="0.7rem" pl="0.3rem" h="60%">
                        <BiPlus />
                        <Text ml="-0.2rem">Listing</Text>
                      </Button>
                    </Center>
                  </Box>
                </Center>
              )}
              <Center>
                <Separator orientation="vertical" height="60%" />
              </Center>

              <Center>
                <Box>
                  <Center marginStart="auto">
                    <Link href="/polatefekaya">
                      <Box maxW="100%">
                        <HStack maxW="100%">
                          <Avatar
                            name="Polat Efe Kaya"
                            src="https://carrentalblobstorage.blob.core.windows.net/userphotos/IMG_4866.JPG"
                          />
                          {!isMobile && (
                            <Stack
                              direction="column"
                              gap={0}
                              pt="0.1rem"
                              maxW="100%"
                            >
                              <Heading mb="-0.1rem" textStyle="md">
                                Polat Efe Kaya
                              </Heading>
                              <Flex maxW="85%" overflow="hidden" mr="-1rem">
                                <Text
                                  mt="-0.1rem"
                                  textStyle="xs"
                                  color="fg.muted"
                                  w="100%"
                                  overflow="hidden"
                                  truncate
                                >
                                  polatefekaya@icloud.com
                                </Text>
                              </Flex>
                            </Stack>
                          )}
                        </HStack>
                      </Box>
                    </Link>
                  </Center>
                </Box>
              </Center>
            </>
          ) : (
            <>
            
                <Center marginStart="auto">
                    <Separator orientation="vertical" height="60%" />
                </Center>

              <Center>
                <Box h="100%">
                  <Center h="100%">
                    <Button variant="subtle" pr="0.7rem" pl="0.3rem" h="60%">
                      <BsArrowRightShort />
                      <Text ml="-0.2rem">Login</Text>
                    </Button>
                  </Center>
                </Box>
              </Center>
              {!isMobile && 
              <Center>
                <Box>
                  <Text ml="-0.2rem" mr="-0.2rem" color="gray">
                    or
                  </Text>
                </Box>
              </Center>
            }
            {!isMobile && 

              <Center>
                <Box h="100%">
                  <Center h="100%">
                    <Button variant="solid" pr="0.7rem" pl="0.3rem" h="60%">
                      <BiPlus />
                      <Text ml="-0.2rem">Register</Text>
                    </Button>
                  </Center>
                </Box>
              </Center>
            }
            </>
          )}
        </Flex>
        <Separator size="md" />
      </Box>
    </>
  );
}
