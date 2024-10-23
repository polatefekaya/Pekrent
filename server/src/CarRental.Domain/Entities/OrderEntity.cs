using System;

namespace CarRental.Domain.Entities;

public class OrderEntity
{
    public int InfoId {get; set;}
    public int ProgressId {get; set;}
    public int AuthenticationId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
