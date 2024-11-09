import { Button, DrawerRoot } from "@chakra-ui/react";
import { DrawerBackdrop, DrawerBody, DrawerCloseTrigger, DrawerContent, DrawerFooter, DrawerHeader, DrawerTitle, DrawerTrigger } from "../ui/drawer";
import { BiMenu } from "react-icons/bi";

export default function NavbarDrawer({handleDrawer}: {handleDrawer:()=>void}){
    return(
        <>
        <DrawerRoot>
            <DrawerBackdrop colorPalette="white"/>
                <DrawerTrigger asChild>
                <Button
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
                  </Button>
                </DrawerTrigger>
                <DrawerContent colorPalette="white"backgroundColor="white" shadow="none">
                    <DrawerHeader>
                        <DrawerTitle>Pekrent</DrawerTitle>
                    </DrawerHeader>
                    <DrawerBody>

                    </DrawerBody>
                    <DrawerFooter>
                        
                    </DrawerFooter>
                    <DrawerCloseTrigger color="black" />
                </DrawerContent>
            
        </DrawerRoot>
        </>
    );
}