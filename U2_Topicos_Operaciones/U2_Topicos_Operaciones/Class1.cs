using System;

namespace U2_Topicos_Operaciones
{
    public class sumatoria
    {

        public static decimal Sumar(decimal a, decimal b)
        {
            return a + b;
        }

        public static String MostrarSuma(decimal a, decimal b)
        {
            decimal resultado= a+b;
            return "El resultado de "+a +"+" + b + "= " + resultado;
        }
    }
}
