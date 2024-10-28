using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_infos", Schema = "order")]
public class OrderInfoEntity : BaseEntity
{
    public int OrderId {get; set;}
    public int ListingId {get; set;}
    public int PriceId {get; set;}
    public DateTime From {get; set;}
    public DateTime To {get; set;}
    public string? State {get; set;}
    public bool Active {get; set;}

    public ListingEntity Listing {get; set;} = null!;
    public PriceEntity Price {get; set;} = null!;
    public OrderEntity Order {get; set;} = null!;
}
