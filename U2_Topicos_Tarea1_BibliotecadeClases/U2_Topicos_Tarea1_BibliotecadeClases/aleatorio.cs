using System;

namespace U2_Topicos_Tarea1_BibliotecadeClases
{
    public class aleatorio
    {
     
        public static void numeroRandom(int numeroInicial, int numeroFinal)
        {
            Random rand = new Random(numeroFinal);
            int numero = rand.Next(numeroInicial, numeroFinal);
            for (int i = numeroInicial; i < numeroFinal; i++)
            {
                int  resultado = rand.Next(numeroFinal);
                Console.WriteLine(resultado);

            }
        }

    }
}