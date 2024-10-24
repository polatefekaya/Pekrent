using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_fines_progresses", Schema = "order")]
public class OrderFinesProgressEntity
{
    [Key]
    public int Id {get; set;}
    public int ProgressId {get; set;}
    public int ChargedFineCount {get; set;}
    public int ChargedTotalAmount {get; set;}
    public bool FinesActive {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
