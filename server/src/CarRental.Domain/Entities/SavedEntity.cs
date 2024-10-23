using System;

namespace CarRental.Domain.Entities;

public class SavedEntity
{
    public int ListingId {get; set;}
    public int UserId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
