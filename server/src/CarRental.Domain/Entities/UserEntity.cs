using System;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

public class UserEntity : BaseEntity
{
    public int AvailabilityId {get; set;}
    public int BlacklistId {get; set;}

    public AvailabilityEntity? Availability {get; set;}
    public BlacklistEntity? Blacklist {get; set;}
    public List<ListingEntity>? Listings {get; set;} = [];
    public List<SavedEntity>? Savings {get; set;} = [];
}
