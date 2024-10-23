using System;

namespace CarRental.Domain.Entities;

public class OrderProgressEntity
{
    public bool OrderCreated {get; set;}
    public int StateCode {get; set;}
    public bool Active {get; set;}
    public bool Finished {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
