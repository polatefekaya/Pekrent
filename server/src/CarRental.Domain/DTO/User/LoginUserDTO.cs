using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.DTO.User;

public record class LoginUserDTO
{
    [Required]
    public string? EMail {get; init;}
    [Required]
    public string? Password {get; init;}
}
