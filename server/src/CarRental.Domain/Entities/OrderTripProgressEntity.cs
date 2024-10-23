using System;

namespace CarRental.Domain.Entities;

public class OrderTripProgressEntity
{
    public int ProgressId {get; set;}
    public bool WaitingPickUp {get; set;}
    public bool Authenticated {get; set;}
    public bool Approved {get; set;}
    public bool InTrip {get; set;}
    public bool Returned {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
