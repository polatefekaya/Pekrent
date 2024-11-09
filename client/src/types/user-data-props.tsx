type BaseUserDataProps = {
        firstName: string;
        lastName: string;
        fullName: string;
        email: string;
        province: string;
        profilePhoto: string;
        username: string;
        distance: number;
}

type UserProps ={
    props: BaseUserDataProps;
}