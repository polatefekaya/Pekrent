type ListingEntryProps = {
  props: BaseListingProps;
};

type InnerListingEntryProps = {
  props: BaseListingProps;
  carProps?: CarDataProps;
  userProps?: BaseUserDataProps;
};

type BaseListingProps = {
  title: string;
  description: string;
  price: number[];
  distance: number;
  location: string;
  username: string;
  listingId: number;
  userId: string;
  currency: string;
  mode?: string;
};
