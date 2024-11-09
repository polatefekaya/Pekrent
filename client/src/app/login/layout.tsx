import TopNavigationBar from "@/components/meui/top-navbar";
import { Metadata } from "next";

export const metadata: Metadata = {
    title: "Pekrent - Login",

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