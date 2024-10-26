using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("availabilities", Schema = "user")]
public class AvailabilityEntity : BaseEntity
{
    public int UserId {get; set;}
    public DateTime LastOnline {get; set;}
    public bool Online {get; set;}
    public DateTime ApproxReplyTime {get; set;}
    
    public UserEntity User {get; set;} = null!;
}
