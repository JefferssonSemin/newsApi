using Microsoft.EntityFrameworkCore;
using NewsApi.DTOs;

namespace NewsApi.Data
{
    public class SqLiteDbContext : DbContext
    {
        public SqLiteDbContext(DbContextOptions<SqLiteDbContext> options) : base(options)
        {
        }

        public DbSet<New> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<New>().HasKey(k => k.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}