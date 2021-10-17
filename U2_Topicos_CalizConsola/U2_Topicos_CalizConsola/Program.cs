using System;

namespace U2_Topicos_CalizConsola
{
    class Program
    {
   
        public static void Main(string[] args)
        {

            aleatorio(1, 10);

        }
                                           
        public static void aleatorio(int numeroInicial, int numeroFinal)
        {
                                         
            Random rand = new Random(numeroFinal);
            int numero = rand.Next(numeroInicial, numeroFinal);
            for (int i = numeroInicial; i < numeroFinal; i++)
            {
                int resultado = rand.Next(numeroFinal) + 100;
                Console.WriteLine(resultado);
            }


        }

    }
}
