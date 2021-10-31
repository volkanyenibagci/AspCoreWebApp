
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AspCoreWebApp.Entities.Models
{
    public class AspCoreContext : DbContext
    {
        public AspCoreContext(DbContextOptions<AspCoreContext> options) : base(options)
        {
        }

        

        /*public AspCoreContext()
        {
            throw new System.NotImplementedException();
        }*/

        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatisHareket> SatisHarekets { get; set; }
        public DbSet<Urun> Uruns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cariler>().ToTable("Carilers");
            modelBuilder.Entity<Departman>().ToTable("Departman");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Personel>().ToTable("Personel");
            modelBuilder.Entity<SatisHareket>().ToTable("SatisHareket");
            modelBuilder.Entity<Urun>().ToTable("Urun");
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AspCoreContext>
        {
            public AspCoreContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<AspCoreContext>();
                var connectionString = "Server=127.0.0.1;Port=5432;Database=aspcore;User Id=postgres;Password=123456;";
                builder.UseNpgsql(connectionString);
                return new AspCoreContext(builder.Options);
            }
        }
    }
}
