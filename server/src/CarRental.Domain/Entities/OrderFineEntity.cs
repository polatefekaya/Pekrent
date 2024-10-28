using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Entities.Base;

namespace CarRental.Domain.Entities;

[Table("order_fines", Schema = "order")]
public class OrderFineEntity : BaseEntity
{
    public int UserId {get; set;}
    public int FinesProgressId {get; set;}
    public string? Description {get; set;}
    public int Code {get; set;}
    public decimal Amount {get; set;}

    public UserEntity User {get; set;} = null!;
    public OrderFinesProgressEntity FinesProgress {get; set;} = null!; 
}
