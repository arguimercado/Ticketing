using Microsoft.AspNetCore.Identity;

namespace Api.Models;

public class User : IdentityUser {
    
    public string FullName { get; set; } = null!;
    public string? Photo { get; set; }
    public string Company { get; set; } = null!;
    public string Branch { get; set; } = null!;
    public string Department { get; set; } = null!;
}