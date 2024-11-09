import { Center, Link, Tabs } from "@chakra-ui/react";
import { useRouter } from "next/navigation";
import { BiCart, BiListMinus, BiListOl, BiListUl, BiMenu, BiReceipt, BiSearch } from "react-icons/bi";

export default function NavigationTabs({selected, authenticated, mode} : NavigationTabProps){
    const router = useRouter();
    const handleRouting = (url: string) => {
        router.push(url);
    }

    if(mode === "general"){
        return (
            <>
                <Tabs.Root defaultValue={selected} size="lg" variant="line" colorPalette="green" >
                    <Tabs.List gap="1rem">
                        <Tabs.Trigger 
                            value="explore"
                            pl="0.9rem" pr="1rem"
                            onClick={() => {
                                handleRouting("/explore")
                            }}
                            focusRing="none"
                            
                        >
                            <BiSearch/>
                                Explore
                        </Tabs.Trigger>
                    </Tabs.List>
                </Tabs.Root>
            </>
        );
    } else if(mode === "yourtabs") {
        return (
            <>
                <Tabs.Root defaultValue={selected} size="lg" variant="line" colorPalette="green" >
                    <Tabs.List gap="1rem">
                        <Tabs.Trigger
                            value="yourlistings"
                            pl="0.5rem" pr="0.5rem"
                            onClick={() => {
                                handleRouting("/zakkolomonoko/listings")
                            }}
                            focusRing="none"
                            disabled={!authenticated}
                            
                        >
                            <BiListUl size="22px"/>
                                Your Listings
                        </Tabs.Trigger>
                        <Tabs.Trigger
                            value="yourorders"
                            pl="0.5rem" pr="0.5rem"
                            onClick={() => {
                                handleRouting("/zakkolomonoko/listings")
                            }}
                            focusRing="none"
                            disabled={!authenticated}
                        >
                            <BiReceipt/>
                                Your Rentings
                        </Tabs.Trigger>
                        
                    </Tabs.List>
                </Tabs.Root>
            </>
        );
    }
    
}