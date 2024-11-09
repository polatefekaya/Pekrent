using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_progresses", Schema = "order")]
public class OrderProgressEntity : BaseEntity
{
    public int OrderId {get; set;}
    public int OrderTripProgressId {get; set;}
    public int OrderFinesProgressId {get; set;}
    public int OrderPaymentProgressId {get; set;}
    public bool OrderCreated {get; set;}
    public int StateCode {get; set;}
    public bool Active {get; set;}
    public bool Cancelled {get; set;}
    public bool Finished {get; set;}

    public OrderEntity Order {get; set;} = null!;
    public OrderTripProgressEntity OrderTripProgress {get; set;} = null!;
    public OrderFinesProgressEntity OrderFinesProgress {get; set;} = null!;
    public OrderPaymentProgressEntity OrderPaymentProgress {get; set;} = null!;
}
