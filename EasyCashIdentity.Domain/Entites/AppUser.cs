using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentity.Domain.Entites;

public class AppUser : IdentityUser<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string ImageUrl { get; set; }
    public List<CustomerAccount> CustomerAccounts { get; set; }
}