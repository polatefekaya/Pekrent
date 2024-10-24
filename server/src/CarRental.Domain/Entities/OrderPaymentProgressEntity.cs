using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_table_progresses", Schema = "order")]
public class OrderPaymentProgressEntity
{
    [Key]
    public int Id {get; set;}
    public int ProgressId {get; set;}
    public bool DownPaymentMade {get; set;}
    public bool DepositPaid {get; set;}
    public bool LeftoutCharged {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
