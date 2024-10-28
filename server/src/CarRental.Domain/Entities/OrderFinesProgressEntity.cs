using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_fines_progresses", Schema = "order")]
public class OrderFinesProgressEntity : BaseEntity
{
    public int ProgressId {get; set;}
    public int ChargedFineCount {get; set;}
    public int ChargedTotalAmount {get; set;}
    public bool FinesActive {get; set;}

    public OrderProgressEntity Progress {get; set;} = null!;
}
