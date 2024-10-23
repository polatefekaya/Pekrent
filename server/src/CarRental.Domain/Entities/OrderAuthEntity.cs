using System;

namespace CarRental.Domain.Entities;

public class OrderAuthEntity
{
    public string? CustomerToken {get; set;}
    public string? DealerToken {get; set;}
    public DateTime Expiration {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}   
