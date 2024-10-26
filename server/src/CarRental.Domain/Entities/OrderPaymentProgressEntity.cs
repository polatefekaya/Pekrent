using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_table_progresses", Schema = "order")]
public class OrderPaymentProgressEntity : BaseEntity
{
    public int ProgressId {get; set;}
    public bool DownPaymentMade {get; set;}
    public bool DepositPaid {get; set;}
    public bool LeftoutCharged {get; set;}

    public OrderProgressEntity Progress {get; set;} = null!;
}
