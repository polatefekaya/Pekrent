import { Heading } from "@chakra-ui/react";

export default function FieldLabel({text}: {text: string}){
    return (
        <>
            <Heading as="h4" marginTop="0">{text}</Heading>
        </>
    );
}