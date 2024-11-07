using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("charges", Schema = "money_transactions")]
public class ChargeEntity : BaseEntity
{
    public int UserId {get; set;}
    public decimal Amount {get; set;}
    public string? Description {get; set;}
    public bool IsRefunded {get; set;}

    public UserEntity User {get; set;} = null!;
}
