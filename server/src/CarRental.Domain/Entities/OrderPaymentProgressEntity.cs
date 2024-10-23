using System;

namespace CarRental.Domain.Entities;

public class OrderPaymentProgressEntity
{
    public int ProgressId {get; set;}
    public bool DownPaymentMade {get; set;}
    public bool DepositPaid {get; set;}
    public bool LeftoutCharged {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
