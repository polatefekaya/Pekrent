using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("availabilities", Schema = "user")]
public class AvailabilityEntity
{
    [Key]
    public int Id {get; set;}
    public int UserId {get; set;}
    public DateTime LastOnline {get; set;}
    public bool Online {get; set;}
    public DateTime ApproxReplyTime {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
