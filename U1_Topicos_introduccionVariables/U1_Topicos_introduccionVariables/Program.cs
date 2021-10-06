using System;
using System.Collections.Generic;

namespace U1_Topicos_introduccionVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            //comentarios de una linea
            /*comentarios de muchas lineas*/


            //variables
            //Nomenclatura: Tipo Nombre= valor;

            string nombre = "Gabriel Hernandez Diaz";
            char caracter = 'A';
            int edad = 28;
            bool soltero = true;
            float estatura = 1.80f;
            var variable = 28;     //intuye el var que es
            Console.WriteLine("edad usando el var " + variable);

            Console.WriteLine(nombre + " tiene: " + edad + " años");
            Console.WriteLine("{0} tiene  {1} y su estatura es {2}", nombre, edad, estatura);
            if (edad < 18)
            {
                Console.WriteLine("aun no puedo tomar");
            }
            else if (edad >= 18 && edad <= 60)
            {
                Console.WriteLine("yo si tomo");
            }
            else
            {
                Console.WriteLine("pistando");

            }
            string genero = "hombre";
            switch (genero)
            {
                case "hombre":
                    Console.WriteLine("ingeniero");
                    break;

                case "mujer":
                    Console.WriteLine("ingeniera");
                    break;
                default:
                    Console.WriteLine("ingeniere");
                    break;

            }
            //ciclo for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("numero {0}", i);
            }
            var numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // foreach
            foreach (int i in numeros)
            {
                Console.WriteLine("Digitos foreach {0}", i);
            }
            //variable dynamic
            dynamic valor = 12;
            Console.WriteLine(valor);
            valor = true;
            Console.WriteLine(valor);
            valor = "cadena";
            Console.WriteLine(valor);


            dynamic nubesPorMiCasa;
            nubesPorMiCasa = 2;     //dia 1
            nubesPorMiCasa = "DOS"; //dia 2
            nubesPorMiCasa = "XXV"; //dia 3

            dynamic var15 = 10;    //el dinamic es mas universal
            var15 = "hola soy una cadena";
            //      var var15 = 10;
            //      var15 = "hola soy una cadena";

            dynamic lista2 = new List<dynamic> { 'a', false, 12.8, "lista" };
            var lista3 = new List<dynamic> { 'a', false, 12.8, "lista" };
            List<dynamic> lista4 = new List<dynamic> { 'a', false, 12.8, "lista" };

            foreach (var item in lista4)
            {
                Console.Write(item + " ");
            }

            //WHILE
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine("WHILE: " + num);
                num++;
            }

            do
            {
                num--;
                Console.WriteLine("DO WHILE: " + num);
            }
            while (num > 0);

            imprimir();
            var resSuma = suma(2, 6);
            Console.WriteLine(resSuma);
            Console.WriteLine(sumaAbr(2, 4));
            imprimirAbr();
            static void imprimir()
            {
                Console.WriteLine("mi primera funcion ");
            }

            static int suma(int a, int b)
            {
                return a + b;
            }
            static int sumaAbr(int a, int b) => a + b;

            static void imprimirAbr() => Console.WriteLine("mi primera funcion con flecha ");

            //  Animal animal1 = new Animal();
            //  animal1.nacer();

            Gato gato1 = new Gato("michi",true);
            gato1.comer("Atun");
            gato1.ruido();

            Pollito pollito1 = new Pollito();
            pollito1.nacer();
            pollito1.comer("maiz");
            pollito1.ruido();
        }
    }
    public abstract class Animal
    {
        String id;
        String especie;

        public void nacer()
        {
            Console.WriteLine("Naciendo...");
        }
        public void comer(string comida)
        {
            Console.WriteLine("Comiendo " + comida);
        }
        public abstract void ruido();



    }

    public class Gato : Animal
    {
        String nombre;
        bool botas;

        public Gato(String nombre, bool botas)
        {
            this.nombre = nombre;
            this.botas = botas;
        }


        public override void ruido()
        {
            Console.WriteLine(" cuando esta feliz ronronea ");
            Console.WriteLine(" cuando esta feliz hace miau ");


        }

    }
    public class Pollito : Animal
    {
        String nombre;
        public override void ruido()
        {
            Console.WriteLine(" pio");
        }

    }
}