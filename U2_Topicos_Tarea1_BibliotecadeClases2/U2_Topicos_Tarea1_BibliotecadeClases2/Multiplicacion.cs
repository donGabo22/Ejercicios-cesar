using System;

namespace U2_Topicos_Tarea1_BibliotecadeClases2
{
    public class Multiplicacion
    {

        public static decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }
        public static String MostrarMultiplicar(decimal a, decimal b)
        {
            decimal res = a * b;
            return "El resultado de: " + a + " x " + b + " = " + res;
        }

    }
}
