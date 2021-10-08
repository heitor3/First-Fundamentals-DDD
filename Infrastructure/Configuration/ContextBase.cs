using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase: DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source = HEITOR\\SQLEXPRESS; Initial Catalog = DDDFIRST; Integrated Security = True";
            return strCon;
        }
    }
}
