namespace CarRental.Domain.DTO.Manager.Order;

public record class StartOrderDTO<T>
{
    public T? Entity {get; init;}
}
