using System;

namespace CarRental.Domain.Entities;

public class OrderFineEntity
{
    public int UserId {get; set;}
    public int FinesProgressId {get; set;}
    public string? Description {get; set;}
    public int Code {get; set;}
    public decimal Amount {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
