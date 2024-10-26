using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("blacklist", Schema = "user")]
public class BlacklistEntity
{
    [Key]
    public int Id {get; set;}
    public int UserId {get; set;}
    public int Code {get; set;}
    public string? Reason {get; set;}
    public DateTime StartDate {get; set;}
    public DateTime EndDate {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
