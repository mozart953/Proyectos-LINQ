using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema", "pay de manzana y pera" };

            bool mayusculas = false;

            IEnumerable<string> resultados;

            var manzanas = postres.Where(n => n.Contains("manzana"));
            var ordenes = manzanas.OrderBy(n => n);


            if (mayusculas)
            {
                resultados = ordenes.Select(n => n.ToUpper());
            }
            else
            {
                resultados = ordenes;
            }

            foreach (string postre in resultados)
                Console.WriteLine(postre);

            Console.WriteLine("-----------------");



        }
    }
}
