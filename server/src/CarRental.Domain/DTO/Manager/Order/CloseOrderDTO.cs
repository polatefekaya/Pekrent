namespace CarRental.Domain.DTO.Manager.Order;

public record class CloseOrderDTO<T>
{
    public T? Entity {get; init;}
}
