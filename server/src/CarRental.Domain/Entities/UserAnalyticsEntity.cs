using System;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("user_analytics", Schema = "user")]
public class UserAnalyticsEntity : BaseEntity
{
    public int UserId {get; set;}
    public decimal Revenue {get; set;}
    public decimal Spent {get; set;}
    public int TotalTraveled {get; set;}
    public int RentedCount {get; set;}

    public UserEntity User {get; set;} = null!;
}
