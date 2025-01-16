using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class EasyCashContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MUCAHID\\MSSQLSERVER01;Database=IdentityDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Currency>? Currencies { get; set; }
        public DbSet<CustomerAccount>? CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess>? CustomerAccountProcesses { get; set; }
    }
}
