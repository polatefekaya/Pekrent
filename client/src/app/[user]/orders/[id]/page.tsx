type UserOrderPageProps = {
    params: { user: string; id: string;};
};

export default function UserOrderPage({ params }: UserOrderPageProps) {
    const { user, id } = params;

    return (
        <>
            <h1>User: {user}</h1>
            <h5>Order Id: {id}</h5>
        </>
    );
}