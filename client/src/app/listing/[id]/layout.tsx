import TopNavigationBar from "@/components/meui/top-navbar";
import { Metadata } from "next";

export const metadata: Metadata = {
    title: "Pekrent - Listing",

};

export default function RootLayout({
    children,
  }: Readonly<{
    children: React.ReactNode;
  }>){
    return(
        <>
            <TopNavigationBar page="listing" authenticated={true}/>
            {children}
        </>
    );
}