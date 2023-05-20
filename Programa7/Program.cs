using System;
using System.Collections.Generic;
using System.Linq;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };
            //diferencia
            var expt = (from n1 in conjunto1 select n1)
                .Except(from n2 in conjunto2 select n2);

            Console.WriteLine("Except");
            foreach (int num in expt)
                Console.WriteLine(num);

            //intercept
            var ints = (from n1 in conjunto1 select n1)
               .Intersect(from n2 in conjunto2 select n2);
            
            Console.WriteLine("Intersect");
            foreach (int num in ints)
                Console.WriteLine(num);

            var un = (from n1 in conjunto1 select n1)
                .Union(from n2 in conjunto2 select n2);

            Console.WriteLine("Union");
            foreach (int num in un)
                Console.WriteLine(num);

            var cnt = (from n1 in conjunto1 select n1)
                .Concat(from n2 in conjunto2 select n2);

            Console.WriteLine("Concat");
            foreach (int num in cnt)
                Console.WriteLine(num);

            Console.WriteLine("Distinct");
            foreach (int num in cnt.Distinct())
                Console.WriteLine(num);

        }
    }
}
