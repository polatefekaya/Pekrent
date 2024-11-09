using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("refunds", Schema = "money_transactions")]
public class RefundEntity : BaseEntity
{
    public int ChargeId {get; set;}
    public int UserId {get; set;}
    public string? Description {get; set;}

    public ChargeEntity Charge {get; set;} = null!;
    public UserEntity User {get; set;} = null!;
}
