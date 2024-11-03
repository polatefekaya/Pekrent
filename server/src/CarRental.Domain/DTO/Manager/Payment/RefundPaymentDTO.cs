namespace CarRental.Domain.DTO.Manager.Payment;

public record class RefundPaymentDTO
{
    public int ChargeId {get; init;}
    public int UserId {get; init;}
    public string? Description {get; init;}
}
