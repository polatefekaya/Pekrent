using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_auths", Schema = "order")]
public class OrderAuthEntity
{
    [Key]
    public int Id {get; set;}
    public string? CustomerToken {get; set;}
    public string? DealerToken {get; set;}
    public DateTime Expiration {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}   
