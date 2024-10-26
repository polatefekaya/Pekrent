using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_auths", Schema = "order")]
public class OrderAuthEntity : BaseEntity
{
    public string? CustomerToken {get; set;}
    public string? DealerToken {get; set;}
    public DateTime Expiration {get; set;}
}   
