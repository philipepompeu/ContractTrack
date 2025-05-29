using ContractTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContractTrack.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
