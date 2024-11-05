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
        {children}
        </>
    );
}