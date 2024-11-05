"use client"

import FieldLabel from "@/components/meui/field-label";
import { Field } from "@/components/ui/field";
import { NativeSelectField, NativeSelectRoot } from "@/components/ui/native-select";
import { PasswordInput } from "@/components/ui/password-input";
import { Box, Center, Fieldset, Heading, Input, Stack, Text } from "@chakra-ui/react";
import { useState } from "react";

export default function RegisterPage() {
    const [passwordVal, setPassword] = useState("");

    return(
        <>
            <Center>
        <Box marginTop="5rem" maxW="90%">
                <Fieldset.Root size="lg" >
                    <Stack>
                        <Fieldset.Legend>
                            <Heading textStyle="4xl">Register</Heading>
                        </Fieldset.Legend>
                        <Fieldset.HelperText>You are opening the doors to freedom of the trips without thinking of car.</Fieldset.HelperText>
                    </Stack>

                    <Fieldset.Content marginTop="2rem">
                        <Field label={<FieldLabel text="Name"/>} required>
                            <Input name="name"/>
                        </Field>

                        <Field label={<FieldLabel text="E-Mail"/>} required>
                            
                            <Input name="email" placeholder="your@mail.com" type="email"/>
                        </Field>

                        <Field label={<FieldLabel text="Password"/>} 
                        required>
                            <PasswordInput name="name"
                            value={passwordVal}
                            onChange={(e) => setPassword(e.target.value)}
                            />
                        </Field>

                        <Field label={<FieldLabel text="Country"/>} helperText="Other countries not available at the moment" disabled>
                            <NativeSelectRoot>
                                <NativeSelectField name="country"
                                    items={["Turkey"]}
                                />
                            </NativeSelectRoot>
                        </Field>

                        <Field label={<FieldLabel text="City"/>} helperText="Other cities not available at the moment" disabled>
                            <NativeSelectRoot>
                                <NativeSelectField name="city"
                                    items={["Istanbul"]}
                                />
                            </NativeSelectRoot>
                        </Field>

                        <Field label={<FieldLabel text="Province"/>}>
                            <NativeSelectRoot>
                                <NativeSelectField name="province"
                                    items={["Adalar", "Arnavutköy", "Ataşehir", "Avcılar", "Bağcılar", "Bahçelievler", "Bakırköy", "Başakşehir", "Bayrampaşa", "Beşiktaş", "Beykoz", "Beylikdüzü", "Beyoğlu", "Büyükçekmece", "Çatalca", "Çekmeköy", "Esenler", "Esenyurt", "Eyüpsultan", "Fatih", "Gaziosmanpaşa", "Güngören", "Kadıköy", "Kağıthane", "Kartal", "Küçükçekmece", "Maltepe", "Pendik", "Sancaktepe", "Sarıyer", "Silivri", "Sultanbeyli", "Sultangazi","Şile", "Şişli", "Tuzla", "Ümraniye", "Üsküdar", "Zeytinburnu"]}
                                />
                            </NativeSelectRoot>
                        </Field>
                    </Fieldset.Content>
                </Fieldset.Root>
        </Box>
            </Center>
        </>
    );
}