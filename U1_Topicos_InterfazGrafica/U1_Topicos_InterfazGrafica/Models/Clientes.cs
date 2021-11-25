﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_Topicos_InterfazGrafica.Models
{
    class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string RFC { get; set; }
    }
}
