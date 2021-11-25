using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_Topicos_InterfazGrafica.Models
{
    class Inventario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public String TipodeProducto { get; set; }

        public String Precio { get; set; }

        public String CantidadEnInventario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public String TechadeCaducidad { get; set; }
    }
}
