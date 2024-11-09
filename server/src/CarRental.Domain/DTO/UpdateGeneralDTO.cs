namespace CarRental.Domain.DTO;

public record class UpdateGeneralDTO<T>
{
    public T? Entity {get; init;}
}
