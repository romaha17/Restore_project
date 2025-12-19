using Microsoft.AspNetCore.Identity;

namespace Restore.Entities;

public class User : IdentityUser
{
    public int? AdressId { get; set; }
    public Address? Address { get; set; }
}