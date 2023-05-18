using EasyCashIdentity.Domain.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EasyCashIdentiy.Persistance.Context;

public class ProjectContext : IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=EYUPPC; initial catalog=EasyCashDb; integrated Security=true");
        
    }

    public DbSet<CustomerAccount> CustomerAccounts { get; set; }
    public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
}