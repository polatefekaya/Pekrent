namespace CarRental.Domain.DTO.Manager.Order;

public record class CancelOrderDTO<T>
{
    public int Id {get; init;}
    public T? Entity {get; init;}
}
