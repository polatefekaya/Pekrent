using System;

namespace CarRental.Domain.Entities;

public class OrderInfoEntity
{
    public int ListingId {get; set;}
    public int PriceId {get; set;}
    public DateTime From {get; set;}
    public DateTime To {get; set;}
    public string? State {get; set;}
    public bool Active {get; set;}
}
