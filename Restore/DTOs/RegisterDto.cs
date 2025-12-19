using System.ComponentModel.DataAnnotations;

namespace Restore.DTOs;

public class RegisterDto
{
    [Required]
    public string Email { get; set; }
    public required string Password { get; set; }
}