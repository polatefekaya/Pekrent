using System;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("users", Schema = "user")]
public class UserEntity : BaseEntity
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
