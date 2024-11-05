import { Card, HStack, Icon } from "@chakra-ui/react";
import { BiSearch } from "react-icons/bi";

export default function LandingCard({
  title,
  description,
  iconNode = undefined,
  noRoundStart = false
}: LandingCardProps) {
    let round: string ="";
    if(noRoundStart) {
        round = "0"
    }
  return (
    <>
      <Card.Root p="1rem" variant="subtle" roundedTopLeft={round}>
        <Card.Body gap="3">
          <HStack>
            {iconNode && (
              <Icon fontSize="3xl" color="green.solid" mr="0.5rem">
                {iconNode}
              </Icon>
            )}
            <Card.Title textStyle="xl">{title}</Card.Title>
          </HStack>
          <Card.Description textStyle="md">{description}</Card.Description>
        </Card.Body>
        <Card.Footer></Card.Footer>
      </Card.Root>
    </>
  );
}
