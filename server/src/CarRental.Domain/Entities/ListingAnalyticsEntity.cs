using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("listing_analytics", Schema = "listing")]
public class ListingAnalyticsEntity : BaseEntity
{
    public int ListingId {get; set;}
    public int PageViews {get; set;}
    public int UniqueViews {get; set;}
    public int PhotoClicks {get; set;}
    public int Rentings {get; set;}
    public int Chatted {get; set;}
    public decimal RevenueMade {get; set;}
    public int DaysRented {get; set;}
    public int KilometersTravelled {get; set;}

    public ListingEntity Listing { get; set;} = null!;
}
