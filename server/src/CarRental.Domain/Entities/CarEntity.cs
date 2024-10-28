using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("cars", Schema = "listing")]
public class CarEntity : BaseEntity
{
    public int ListingId {get; set;}
    public string? BlobStorage {get; set;}
    public string? Model {get; set;}
    public string? Brand {get; set;}
    public int Year {get; set;}
    public int Doors {get; set;}
    public int Torque {get; set;}
    public double FuelConsumption {get; set;}
    public double FuelConsumptionInnerCity {get; set;}
    public int HorsePower {get; set;}
    public int TopSpeed {get; set;}
    public string? FuelType {get; set;}
    public string? Body {get; set;}
    public int Range {get; set;}
    public int FuelCapacity {get; set;}
    public double Acceleration {get; set;}
    public int Seats {get; set;}
    public string? Drivetrain {get; set;}
    public string? Gearbox {get; set;}
    public string? Usecase {get; set;}
    public int TrunkCapacity {get; set;}

    public List<ListingEntity> Listings {get; set;} = [];
}
