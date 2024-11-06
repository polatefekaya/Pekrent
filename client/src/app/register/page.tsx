"use client"

import FieldLabel from "@/components/meui/field-label";
import { Field } from "@/components/ui/field";
import { NativeSelectField, NativeSelectRoot } from "@/components/ui/native-select";
import { PasswordInput } from "@/components/ui/password-input";
import { Box, Center, Fieldset, Heading, Input, Link, Stack, Text } from "@chakra-ui/react";
import { useState } from "react";
import { Button } from "@/components/ui/button";
import { useRouter } from "next/navigation";

export default function RegisterPage() {
    const [firstName,setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email,setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [province, setProvince] = useState("");
    const [city, setCity] = useState("Istanbul");
    const [country, setCountry] = useState("Turkiye");
    const [isSubmitted, setSubmitted] = useState(false);
    const router = useRouter();

    const handleSubmit = () => {
        console.log(firstName, " ", lastName, " ", email, " ", password, " ", province, " ", city, " ", country);
        setSubmitted(true)
        router.push("/explore")
    }

    return (
        <>
            <Stack>

                <Center>
                    <Box
                        w="100vw"
                        
                        bgImage={"url('wBG3.jpg')"}
                        bgPos="center"
                        bgRepeat="no-repeat"
                        bgSize={{ base: 'cover' }}
                        paddingTop={{base: "2.5rem", sm: "3rem", md: "4rem", lg: "5rem", xl: "6rem"}}
                        paddingBottom={{base: "2.5rem", sm: "3rem", md: "4rem", lg: "5rem", xl: "6rem"}}
                        paddingLeft={{base: "1rem", sm: "2rem", md: "4rem", lg: "8rem", xl: "16rem"}}
                        paddingRight={{base: "1rem", sm: "2rem", md: "4rem", lg: "8rem", xl: "16rem"}}
                    >
                        <Heading textStyle={{base: "5xl", md: "6xl", xl: "7xl"}} marginBottom="1rem">Register</Heading>
                        <Heading fontWeight="normal" background="whiteAlpha.300" as="h4">You're about to unlock the freedom to explore without the hassle of car ownership.</Heading>
                    </Box>
                </Center>
                <Center>
                    <Box marginTop={{base: "1rem",sm: "2rem", md: "3rem"}} maxW="90%" minW={{base: "90vw", sm: "90vw", md: "70vw", lg: "50vw",xl: "35vw"}}>
                        <Fieldset.Root size="lg">
                            <Text>Create an account and join millions experiencing the ease and freedom of travel with Pekrent.</Text>
                            <Fieldset.Content marginTop="2rem">
                                <Field label={<FieldLabel text="First Name" />} required>
                                    <Input
                                        name="firstname"
                                        paddingLeft="1rem"
                                        value={firstName}
                                        onChange={(e) => setFirstName(e.currentTarget.value)}
                                        />
                                </Field>

                                <Field label={<FieldLabel text="Last Name" />} required>
                                    <Input
                                        name="lastname"
                                        paddingLeft="1rem"
                                        value={lastName}
                                        onChange={(e) => setLastName(e.currentTarget.value)}
                                    />
                                </Field>

                                <Field label={<FieldLabel text="E-Mail" />} required>

                                    <Input
                                        name="email"
                                        placeholder="your@mail.com"
                                        type="email"
                                        paddingLeft="1rem"
                                        value={email}
                                        onChange={(e) => setEmail(e.currentTarget.value)}
                                    />
                                </Field>

                                <Field label={<FieldLabel text="Password" />}
                                    required>
                                    <PasswordInput name="password"
                                        paddingLeft="1rem"
                                        value={password}
                                        onChange={(e) => setPassword(e.target.value)}
                                    />
                                </Field>

                                <Field label={<FieldLabel text="Country" />} helperText="Other countries not available at the moment" disabled>
                                    <NativeSelectRoot>
                                        <NativeSelectField name="country"
                                            items={["Turkey"]}
                                            paddingLeft="1rem"
                                        />
                                    </NativeSelectRoot>
                                </Field>

                                <Field label={<FieldLabel text="City" />} helperText="Other cities not available at the moment" disabled>
                                    <NativeSelectRoot>
                                        <NativeSelectField name="city"
                                            items={["Istanbul"]}
                                            paddingLeft="1rem"
                                        />
                                    </NativeSelectRoot>
                                </Field>

                                <Field label={<FieldLabel text="Province" />} required>
                                    <NativeSelectRoot>
                                        <NativeSelectField name="province"
                                            placeholder="-Select-"
                                            value={province}
                                            onChange={(e) => setProvince(e.currentTarget.value)}
                                            items={["Adalar", "Arnavutköy", "Ataşehir", "Avcılar", "Bağcılar", "Bahçelievler", "Bakırköy", "Başakşehir", "Bayrampaşa", "Beşiktaş", "Beykoz", "Beylikdüzü", "Beyoğlu", "Büyükçekmece", "Çatalca", "Çekmeköy", "Esenler", "Esenyurt", "Eyüpsultan", "Fatih", "Gaziosmanpaşa", "Güngören", "Kadıköy", "Kağıthane", "Kartal", "Küçükçekmece", "Maltepe", "Pendik", "Sancaktepe", "Sarıyer", "Silivri", "Sultanbeyli", "Sultangazi", "Şile", "Şişli", "Tuzla", "Ümraniye", "Üsküdar", "Zeytinburnu"]}
                                            paddingLeft="1rem"
                                        />
                                    </NativeSelectRoot>
                                </Field>
                            </Fieldset.Content>
                            
                            <Stack marginBottom="2rem">
                                <Button
                                    type="submit"
                                    marginTop="2rem"
                                    marginBottom="0.75rem"
                                    onClick={handleSubmit}
                                    loading={isSubmitted}
                                >
                                    Register
                                </Button>
                                <Center>
                                    <Box>
                                        <Stack direction="row">
                                            <Center>
                                                <Text textStyle="sm" color="blackAlpha.700" marginRight="1rem">If you have an account</Text>
                                                <Link href="/login">
                                                    <Button size="sm" w="4rem" variant="surface">Login</Button>
                                                </Link>
                                            </Center>
                                        </Stack>
                                    </Box>
                                </Center>
                            </Stack>
                        </Fieldset.Root>
                    </Box>
                </Center>
            </Stack>
        </>
    );
}