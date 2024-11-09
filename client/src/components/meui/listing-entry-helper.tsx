import {
  Box,
  Center,
  Flex,
  Heading,
  HStack,
  Link,
  Separator,
  Stack,
  Text,
} from "@chakra-ui/react";
import { BiCake, BiCar, BiGasPump } from "react-icons/bi";
import { FaRoad } from "react-icons/fa";
import { GiPathDistance } from "react-icons/gi";
import { MdDateRange } from "react-icons/md";
import { PiSeat } from "react-icons/pi";
import { RiPinDistanceFill } from "react-icons/ri";
import { Avatar } from "../ui/avatar";

export function Price({ props }: { props: BaseListingProps }) {
  return (
    <>
      <Stack direction="row"  gap={0}>
        <Stack direction="row" alignItems="flex-end" gap={0}>
          <Text textStyle="2xl" fontWeight="bold">
            {props.price[0]}
            {props.currency}
          </Text>
          <Text
            textStyle="xl"
            fontWeight="bold"
            color="blackAlpha.700"
            ml="0.1rem"
          >
            /h
          </Text>
        </Stack>
        <Center>
        <Separator orientation="vertical"  height="60%" ml="0.3rem"/>
        </Center>
        <Stack direction="row" alignItems="flex-end" gap={0} pb="0.2rem">
          <Text ml="0.3rem" textStyle="sm" color="gray" fontWeight="bold ">{props.price[1]}</Text>
          <Text textStyle="xs" color="gray">/d</Text>
          <Text ml="0.3rem" textStyle="xs" color="gray.400">{props.price[2]}</Text>
          <Text textStyle="2xs" color="gray.400">/w</Text>
          <Text ml="0.3rem" textStyle="xs" color="gray.400">{props.price[3]}</Text>
          <Text textStyle="2xs" color="gray.400">/m</Text>
        </Stack>
      </Stack>
    </>
  );
}

export function UserDetails({ props }: { props?: BaseUserDataProps }) {
  return (
    <>
      <Box>
        <Stack>
          <Link href="/">
            <Stack direction="row">
              <Avatar
                name={props?.fullName}
                size="xs"
                src={props?.profilePhoto}
              />
              <Center>
                <Box>
                  <Flex maxW="90%" overflow="hidden">
                    <Text
                      mt="-0.1rem"
                      textStyle="xs"
                      color="fg.muted"
                      w="100%"
                      overflow="hidden"
                      truncate
                    >
                      {props?.fullName}
                    </Text>
                  </Flex>
                </Box>
              </Center>
            </Stack>
          </Link>
          <Separator mt="0.2rem" mb="0.2rem" />
          <Text textStyle="sm" fontWeight="semibold" mb="-0.2rem">
            {props?.distance} Km
          </Text>
          <Text textStyle="xs" color="gray" mt="-0.2rem">
            {props?.province}
          </Text>
        </Stack>
      </Box>
    </>
  );
}

export function ListingDetails() {
  return <></>;
}

export function CarDetails({ carProps }: { carProps?: CarDataProps }) {
  return (
    <>
      <Box>
        <Stack direction="row" gap="1rem">
          <Stack direction="column" gap="1rem">
            <CarDetail
              detail={carProps?.seats}
              icon={<PiSeat color="gray" size="14px" />}
              name="Seats"
            />

            <CarDetail
              detail={`${carProps?.range} km`}
              icon={<RiPinDistanceFill color="gray" size="14px" />}
              name="Range"
            />
          </Stack>
          <Stack direction="column" gap="1rem">
            <CarDetail
              detail={carProps?.fuelType}
              icon={<BiGasPump color="gray" size="14px" />}
              name="Fuel"
            />
            <CarDetail
              detail={carProps?.year}
              icon={<BiCake color="gray" size="14px" />}
              name="Year"
            />
          </Stack>
          <Stack direction="column" gap="1rem">
            <CarDetail
              detail={carProps?.body}
              icon={<BiCar color="gray" size="14px" />}
              name="Body"
            />
            <CarDetail
              detail={`${carProps?.fuelConsumption} lt`}
              icon={<FaRoad color="gray" size="14px" />}
              name="Consm."
            />
          </Stack>
        </Stack>
      </Box>
    </>
  );
}

function CarDetail({
  detail,
  icon,
  name,
}: {
  detail?: string | number;
  icon: React.ReactNode;
  name?: string;
}) {
  return (
    <>
      <Stack gap="0.2rem">
        <Center>
          <Text>{detail}</Text>
        </Center>
        <Center>
          <Stack direction="row" gap="0.2rem">
            <Center>{icon}</Center>
            <Text textStyle="xs" color="gray">
              {name}
            </Text>
          </Stack>
        </Center>
      </Stack>
    </>
  );
}

export function BrandDetails({ carProps }: { carProps?: CarDataProps }) {
  return (
    <>
      <Box>
        <Text textStyle="sm" fontWeight="medium" color="blackAlpha.700">
          {carProps?.brand} - {carProps?.model} - {carProps?.engineVolume}
        </Text>
      </Box>
    </>
  );
}
