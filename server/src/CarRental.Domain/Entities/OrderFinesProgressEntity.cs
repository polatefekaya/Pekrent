using System;

namespace CarRental.Domain.Entities;

public class OrderFinesProgressEntity
{
    public int ProgressId {get; set;}
    public int ChargedFineCount {get; set;}
    public int ChargedTotalAmount {get; set;}
    public bool FinesActive {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
