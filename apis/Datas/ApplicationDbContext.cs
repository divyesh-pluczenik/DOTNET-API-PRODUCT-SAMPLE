using Microsoft.EntityFrameworkCore;
using RoughDataWebApi.apis.Models;

namespace RoughDataWebApi.apis.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TableModel> TableModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableModel>()
                .ToTable("TableName")
                .HasKey(g => g.COL_1_LONG_PK); // define pK

            base.OnModelCreating(modelBuilder);
        }

    }
}
