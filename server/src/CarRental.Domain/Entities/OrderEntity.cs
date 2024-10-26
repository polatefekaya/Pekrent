using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("orders", Schema = "order")]
public class OrderEntity : BaseEntity
{
    public int InfoId {get; set;}
    public int ProgressId {get; set;}
    public int AuthenticationId {get; set;}

    public OrderInfoEntity Info {get; set;} = null!;
    public OrderProgressEntity Progress {get; set;} = null!;
    public OrderAuthEntity Authentication {get; set;} = null!;
}
