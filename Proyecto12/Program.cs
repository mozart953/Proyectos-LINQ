using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema", "pay de pera y manzana" };

            Console.WriteLine("------- Where ----\r\n");

            IEnumerable<string> r1 = postres.Where((n, i)=>i % 2 == 0);

            foreach (string postre in r1)
                Console.WriteLine(postre);

            Console.WriteLine("-------------------");

            IEnumerable<string> r2 = from p in postres
                                     where p.StartsWith("pay")
                                     select p;

            foreach (string postre in r2)
                Console.WriteLine(postre);

            Console.WriteLine("-------------------------");




           
        }
    }
}
