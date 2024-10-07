using Microsoft.EntityFrameworkCore;
using RoughDataWebApi.apis.Models;

namespace RoughDataWebApi.apis.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Goods> Goods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Goods>()
                .ToTable("Goods")
                // .ToTable("theirGoodsd")
                .HasKey(g => g.TGD_PK);

            base.OnModelCreating(modelBuilder);
        }

    }
}
