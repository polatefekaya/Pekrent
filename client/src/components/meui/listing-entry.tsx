export default function ListingEntry({mode = "standard"} : ListingEntryProps){

    switch (mode) {
        case "standard":
            return(
                <StandardListing/>
            );
        case "superlong":
            return(
                <SuperLongListing/>
            );
        case "long":
            return(
                <LongListing/>
            );
        case "short":
            return(
                <ShortListing/>
            );
        default:
            return(
                <StandardListing/>
            );
    }
}

function SuperLongListing(){
    return (
        <>
        </>
    );
}

function LongListing(){
    return (
        <>
        </>
    );
}

function StandardListing(){
    return (
        <>
        </>
    );
}

function ShortListing(){
    return (
        <>
        </>
    );
}

function BaseListing({} : BaseListingProps){
    return (
        <>
        </>
    );
}