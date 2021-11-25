using System;

namespace U3_EXAMEN_PASTELERIA.Models
{
    class Pedido
    {
        public int Id { get; set; }
        public String NombredelCliente { get; set; }
        public String DirecciondelCliente { get; set; }
        public String NumerodeCelular { get; set; }
        public String TipodePastel { get; set; }
        public String Precio { get; set; }
    }
}
