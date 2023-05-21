using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            IEnumerable<int> desdeInicio = numeros.Take(5);

            foreach (int num in desdeInicio)
                Console.WriteLine(num);

            Console.WriteLine("-------------");

            IEnumerable<int> brinco = numeros.Skip(5);

            foreach (int num in brinco)
                Console.WriteLine(num);

            Console.WriteLine("---------------");

            IEnumerable<int> reverse = numeros.Reverse();

            foreach (int num in reverse)
                Console.WriteLine(num);


            Console.WriteLine("--------------");

            //Encontramos primero

            Console.WriteLine("El primero es {0}", numeros.First());

            Console.WriteLine("El ultimo es {0}", numeros.Last());

            Console.WriteLine("En el indice 3 esta {0}", numeros.ElementAt(3));

            Console.WriteLine("Contiene el 15 - {0}", numeros.Contains(15));
            Console.WriteLine("Tiene el elemento - {0}", numeros.Any());

            Console.WriteLine(" Hay multiplos de 5 - {0}", numeros.Any(n=>n%5==0));

            Console.WriteLine("------------------------");


            int valor = 2;

            IEnumerable<int> resultados = numeros.Where(n => n % valor == 0);
            valor = 3;

            foreach (int n in resultados)
                Console.WriteLine(n);


        }
    }
}
