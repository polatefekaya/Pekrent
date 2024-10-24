using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("listing_savings", Schema = "listing")]
public class SavedEntity
{
    [Key]
    public int Id {get; set;}
    public int ListingId {get; set;}
    public int UserId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
