using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("orders", Schema = "order")]
public class OrderEntity
{
    [Key]
    public int Id {get; set;}
    public int InfoId {get; set;}
    public int ProgressId {get; set;}
    public int AuthenticationId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
