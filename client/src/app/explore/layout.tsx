import TopNavigationBar from "@/components/meui/top-navbar";
import { Text } from "@chakra-ui/react";
import { Metadata } from "next";
import { Suspense } from "react";

export const metadata: Metadata = {
    title: "Pekrent - Explore",

};

export default function RootLayout({
    children,
  }: Readonly<{
    children: React.ReactNode;
  }>){
    return(
        <>
            <TopNavigationBar mode=""/>
            {children}
        </>
    );
}