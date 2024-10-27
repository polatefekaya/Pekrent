using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("prices", Schema = "listing")]
public class PriceEntity : BaseEntity
{
    public int ListingId {get; set;}
    public decimal HourlyRate {get; set;}
    public decimal DailyRate {get; set;}
    public decimal WeeklyRate {get; set;}
    public decimal MonthlyRate {get; set;}
    public bool RentHourly {get; set;}
    public bool RentDaily {get; set;}
    public bool RentWeekly {get; set;}
    public bool RentMonthly {get; set;}
    public string? AppliedCity {get; set;}
    public string? Currency {get; set;}
    public bool WeekendPrice {get; set;}
    public bool ExplicitDay {get; set;}
    public string? Day {get; set;}

    public ListingEntity Listing {get; set;} = null!; 
    public List<OrderInfoEntity>? OrderInfos {get; set;} = [];
}
