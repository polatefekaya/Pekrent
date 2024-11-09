namespace CarRental.Payment.Data.DTO;

public record class RefundDTO
{
    public int ChargeId {get; init;}
    public int UserId {get; init;}
    public string? Description {get; init;}
}
