using System;

namespace CarRental.Domain.Entities;

public class BlacklistEntity
{
    public int UserId {get; set;}
    public int Code {get; set;}
    public string? Reason {get; set;}
    public DateTime Time {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
