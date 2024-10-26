using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("blacklist", Schema = "user")]
public class BlacklistEntity : BaseEntity
{
    public int UserId {get; set;}
    public int Code {get; set;}
    public string? Reason {get; set;}
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}

    public UserEntity User {get; set;} = null!;
}
