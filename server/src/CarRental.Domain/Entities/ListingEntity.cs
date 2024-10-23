using System;

namespace CarRental.Domain.Entities;

public class ListingEntity
{
    public int UserId {get; set;}
    public int CarId {get; set;}
    public string? Heading {get; set;}
    public string? Description {get; set;}
    public int TotalCars {get; set;}
    public int Booked {get; set;}
    public int Left {get; set;}
    public bool AllBooked {get; set;}
    public bool CanGoOuterCity {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
