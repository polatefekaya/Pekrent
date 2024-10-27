using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("listings", Schema = "listing")]
public class ListingEntity : BaseEntity
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

    public UserEntity User {get; set;} = null!;
    public CarEntity Car {get; set;} = null!;
    public List<PriceEntity>? Prices {get; set;} = [];
    public List<SavedEntity>? Savings {get; set;} = [];
    public List<OrderInfoEntity>? OrderInfos {get; set;} = [];
}
