using System;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;
using Microsoft.AspNetCore.Identity;

namespace CarRental.Domain.Entities;

public class UserEntity : IdentityUser
{
    public int AvailabilityId {get; set;}
    public int BlacklistId {get; set;}
    public int UserAnalyticsId {get; set;}

    public AvailabilityEntity? Availability {get; set;}
    public BlacklistEntity? Blacklist {get; set;}
    public UserAnalyticsEntity Analytics {get; set;} = null!;
    public List<ListingEntity>? Listings {get; set;} = [];
    public List<SavedEntity>? Savings {get; set;} = [];
    public List<ChargeEntity>? Charges {get; set;} = [];
    public List<RefundEntity>? Refunds {get; set;} = [];
}
