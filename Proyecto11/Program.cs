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

            bool mayusculas =true;

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


            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p
                                              into pays
                                              where pays.Contains("pay")
                                              select pays;
            foreach (string postre in encontrados)
                Console.WriteLine(postre);

            Console.WriteLine("--------------------");

            //Envolver queries

            IEnumerable<string> mipay = from p in
                                            (
                                                from p1 in postres
                                                where p1.Contains("manzana")
                                                orderby p1
                                                select p1
                                            )
                                        where p.Contains("pay")
                                        select p;

            foreach (string postre in mipay)
                Console.WriteLine(postre);

            Console.WriteLine("-----------------------");

            //let nos permite colocar una nueva variable junto con la de rango

            IEnumerable<string> mispays = from p in postres
                                          let manzanitas = (
                                             from p1 in postres
                                             where p1.Contains("manzana")
                                             orderby p1
                                             select p1
                                             )
                                          where manzanitas.Contains("pay")
                                          select p;


            foreach(string postre in mispays)
            {
                Console.WriteLine(postre);
            }

        }
    }
}
