using Microsoft.AspNetCore.Identity;

namespace SmartInventoryHisab.Model;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}
