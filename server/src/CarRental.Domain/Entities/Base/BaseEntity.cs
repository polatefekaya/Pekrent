using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.Entities.Base;

public abstract class BaseEntity
{
    [Key]
    public int Id {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;
}
