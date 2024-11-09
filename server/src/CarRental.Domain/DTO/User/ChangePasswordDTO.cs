using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.DTO.User;

public record class ChangePasswordDTO
{
    [Required]
    public string? Email { get; init; }
    [Required]
    public string? CurrentPassword { get; init; }
    [Required]
    public string? NewPassword { get; init; }
}
