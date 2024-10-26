using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_progresses", Schema = "order")]
public class OrderProgressEntity : BaseEntity
{
    public bool OrderCreated {get; set;}
    public int StateCode {get; set;}
    public bool Active {get; set;}
    public bool Finished {get; set;}
}
