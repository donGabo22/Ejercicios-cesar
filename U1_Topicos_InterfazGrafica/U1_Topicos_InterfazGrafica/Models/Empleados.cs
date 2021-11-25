using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_Topicos_InterfazGrafica.Models
{
    class Empleados
    {

        //EFC Toma siempre la propiedad id como llave primaria
        public int Id { get; set; }
        public String Nombre { get; set; }

        public String ApellidoPaterno { get; set; }

        public String ApellidoMaterno { get; set; }

        public String Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String RFC { get; set; }
    }
}
