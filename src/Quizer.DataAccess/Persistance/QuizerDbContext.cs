using Microsoft.EntityFrameworkCore;

namespace Quizer.DataAccess.Persistance
{
    internal class QuizerDbContext : DbContext
    {
        public QuizerDbContext() : base()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("data source=WIN-IFLFGEB9GEO;initial catalog=Quizer;TrustServerCertificate=True");
        }
    }
}
