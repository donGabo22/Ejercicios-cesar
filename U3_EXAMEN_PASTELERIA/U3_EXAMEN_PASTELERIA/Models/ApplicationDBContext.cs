using Microsoft.EntityFrameworkCore;

namespace U3_EXAMEN_PASTELERIA.Models
{
    class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Pasteleria; Integrated Security=true").EnableSensitiveDataLogging(true);
        }

        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

    }
}
