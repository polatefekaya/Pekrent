using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.Entities;

public class RefundEntity
{
    [Key]
    public int Id {get; set;}
    public int ChargeId {get; set;}
    public int UserId {get; set;}
    public string? Description {get; set;}

    public ChargeEntity Charge {get; set;} = null!;
    public UserEntity User {get; set;} = null!;
}
