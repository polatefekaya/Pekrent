using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities;

[Table("order_infos", Schema = "order")]
public class OrderInfoEntity
{
    [Key]
    public int Id {get; set;}
    public int ListingId {get; set;}
    public int PriceId {get; set;}
    public DateTime From {get; set;}
    public DateTime To {get; set;}
    public string? State {get; set;}
    public bool Active {get; set;}
}
