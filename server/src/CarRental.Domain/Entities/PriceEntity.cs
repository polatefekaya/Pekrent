using System;

namespace CarRental.Domain.Entities;

public class PriceEntity
{
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
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
