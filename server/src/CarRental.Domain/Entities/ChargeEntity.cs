using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.Entities;

public class ChargeEntity
{
    [Key]
    public int Id {get; set;}
    public int UserId {get; set;}
    public decimal Amount {get; set;}
    public string? Description {get; set;}
    public bool IsRefunded {get; set;}

    public UserEntity User {get; set;} = null!;
}
