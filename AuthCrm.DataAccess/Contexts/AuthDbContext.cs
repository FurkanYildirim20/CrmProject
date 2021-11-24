using AuthCrm.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthCrm.DataAccess.Contexts
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
         : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Adress>().HasOne(t => t.Company).WithMany(t => t.Adresses).HasForeignKey(t => t.CompanyId);
            builder.Entity<Adress>().HasOne(t => t.City).WithMany(t => t.Adresses).HasForeignKey(t => t.CityId);
            builder.Entity<Adress>().HasOne(t => t.Country).WithMany(t => t.Adresses).HasForeignKey(t => t.CountryId);
            builder.Entity<City>().HasOne(t => t.Country).WithMany(t => t.Cities).HasForeignKey(t => t.CountryId);
            builder.Entity<Customer>().HasOne(t => t.Company).WithMany(t => t.Customers).HasForeignKey(t => t.CompanyId);

            base.OnModelCreating(builder);
        }
    }
}