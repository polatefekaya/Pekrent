using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("listing_savings", Schema = "listing")]
public class SavedEntity : BaseEntity
{
    public int ListingId {get; set;}
    public int UserId {get; set;}

    public ListingEntity Listing {get; set;} = null!;
    public UserEntity User {get; set;} = null!;
}
