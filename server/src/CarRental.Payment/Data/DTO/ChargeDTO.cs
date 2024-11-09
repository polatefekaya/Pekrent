using System.ComponentModel.DataAnnotations;

namespace CarRental.Payment.Data.DTO;

public record class ChargeDTO
{
    public int Id {get; init;}
    public int UserId {get; init;}
    [Range(0,1000000)]
    public decimal Amount {get; init;}
    public string? Description {get; init;}
}
