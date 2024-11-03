using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.DTO.Manager.Payment;

public record class ChargePaymentDTO
{
    public int UserId {get; init;}
    public string? Description {get; init;}
    [Range(0,1000000)]
    public decimal Amount {get; init;}
}
