using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.DTO.User;

public record class RegisterUserDTO
{
    [Required]
    public string? FirstName {get; init;}
    [Required]
    public string? LastName {get; init;}
    [Required]
    public string? EMail {get; init;}
    [Required]
    public string? UserName {get; init;}
    [Required]
    public string? Password {get; init;}
}
