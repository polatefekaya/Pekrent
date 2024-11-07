type ListingEntryProps = {
    props: BaseListingProps;
}

type InnerListingEntryProps = {
    props: BaseListingProps;
    carProps?: CarDataProps;
}

type BaseListingProps = {
    title: string;
    description: string;
    price: number[];
    distance: number;
    location: string;
    username: string;
    listingId: number;
    userId: string;
    mode?: string;
}