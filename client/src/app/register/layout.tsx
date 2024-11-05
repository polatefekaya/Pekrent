import TopNavigationBar from "@/components/meui/top-navbar";
import { Theme } from "@chakra-ui/react";
import { Metadata } from "next";
import "./../globals.css";
export const metadata: Metadata = {
    title: "Pekrent - Register",
};

export default function RootLayout({
    children,
  }: Readonly<{
    children: React.ReactNode;
  }>){
    return(
        <>
            <Theme appearance="light">
              <TopNavigationBar/>
              {children}
            </Theme>
        </>
    );
}