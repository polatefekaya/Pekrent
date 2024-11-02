namespace CarRental.Domain.DTO.Order.Info;

public record class SetInfoDatesDTO
{
    public DateTime From {get; init;}
    public DateTime To {get; init;}
}
