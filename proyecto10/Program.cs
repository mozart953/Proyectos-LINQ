using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> resultados = postres.OrderBy(p => p.Split().Last());

            foreach (string postre in resultados)
                Console.WriteLine(postre);

            Console.WriteLine("-------------");

            int[] numeros = { 19, 14, 56, 32, 11, 8, 45, 7,18, 2, 17, 23 };

            IEnumerable<int> num = numeros
                .Where(n => n < numeros.First());

            foreach(int n in num)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------");


            IEnumerable<int> num2 = numeros
                .Where(n => n <= (numeros.Where(n2 => n2 % 2 == 0)).First());

            foreach (int n in num2)
                Console.WriteLine(n);

            Console.WriteLine("----------------");


        }
    }
}
