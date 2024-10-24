using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("listings", Schema = "listing")]
public class ListingEntity
{
    [Key]
    public int Id {get; set;}
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
