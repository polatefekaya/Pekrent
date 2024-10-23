using System;

namespace CarRental.Domain.Entities;

public class AvailabilityEntity
{
    public int UserId {get; set;}
    public DateTime LastOnline {get; set;}
    public bool Online {get; set;}
    public DateTime ApproxReplyTime {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
