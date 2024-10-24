using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_fines", Schema = "order")]
public class OrderFineEntity
{
    [Key]
    public int Id {get; set;}
    public int UserId {get; set;}
    public int FinesProgressId {get; set;}
    public string? Description {get; set;}
    public int Code {get; set;}
    public decimal Amount {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
