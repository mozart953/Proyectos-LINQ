using System;
using System.Collections.Generic;

namespace proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> resultados = CClaseExplicita.ObtenerNumerosPares();

            foreach (int num in resultados)
                Console.WriteLine(num);

            Console.WriteLine("--------------------");


            IEnumerable<string> postres = CClaseExplicita.ObtenerPostres();

            foreach (string p in postres)
                Console.WriteLine(p);

            Console.WriteLine("--------------------");

            int[] impares = CClaseExplicita.ObtenerNumerosImpares();

            foreach (int n in impares)
                Console.WriteLine(n);



        }
    }
}
