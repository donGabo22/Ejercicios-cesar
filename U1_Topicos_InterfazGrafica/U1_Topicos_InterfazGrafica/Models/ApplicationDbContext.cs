using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_Topicos_InterfazGrafica.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Clase; Integrated Security=true").EnableSensitiveDataLogging(true);
        }
         
        //propiedad la cual le indica a Entiti frame core que vamos a tener una tabla empleados
        public DbSet<Empleados> Empleado { get; set;}
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Inventario> Inventario { get; set; }



    }
    }

