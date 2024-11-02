namespace CarRental.Domain.DTO;

public record class AddGeneralDTO<T>
{
    public T? Entity {get; init;}
}
