namespace CarRental.Domain.DTO.Blacklist;

public record class SetDateDTO
{
    public DateTime StartDate {get; init;}
    public DateTime EndDate {get; init;}
}
