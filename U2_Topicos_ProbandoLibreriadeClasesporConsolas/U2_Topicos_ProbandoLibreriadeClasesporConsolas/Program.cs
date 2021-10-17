using System;

namespace U2_Topicos_ProbandoLibreriadeClasesporConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            Console.WriteLine("Dime desde que numero empezar a contar: ");
            v1 = (int)Math.Round(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dime hasta que numero quieres que pare:: ");
            v2=(int)Math.Round(double.Parse(Console.ReadLine()));

            Console.WriteLine("\n Numeros aleatorios: ");
            U2_Topicos_ProbandoLibreriadeConsola.randomConsola.aleatorioConsola(v1, v2);



        }
    }
}
