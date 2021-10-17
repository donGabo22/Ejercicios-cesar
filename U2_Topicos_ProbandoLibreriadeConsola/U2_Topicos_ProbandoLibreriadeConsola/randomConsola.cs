using System;

namespace U2_Topicos_ProbandoLibreriadeConsola
{
    public class randomConsola
    {


        public static void aleatorioConsola(int numeroInicial, int numeroFinal)
        {
            Random rand = new Random(numeroFinal);
            int numero = rand.Next(numeroInicial, numeroFinal);
            for (int i = numeroInicial; i < numeroFinal; i++)
            {
                int resultado = rand.Next(numeroFinal);
                Console.WriteLine("No."+(i+1)+" = "+resultado);

            }
        }

    }
}