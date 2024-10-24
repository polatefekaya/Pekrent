using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_progresses", Schema = "order")]
public class OrderProgressEntity
{
    [Key]
    public int Id {get; set;}
    public bool OrderCreated {get; set;}
    public int StateCode {get; set;}
    public bool Active {get; set;}
    public bool Finished {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
