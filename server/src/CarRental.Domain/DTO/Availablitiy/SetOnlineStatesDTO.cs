namespace CarRental.Domain.DTO.Availablitiy;

public record class SetOnlineStatesDTO
{
    public bool Online {get; init;}
    public DateTime LastOnline {get; init;}
}
