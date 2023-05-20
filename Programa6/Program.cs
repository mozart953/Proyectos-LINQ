using System;
using System.Collections.Generic;
using System.Linq;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia",10.0),
                new CEstudiante("Luis", "5250", "Orientacion a objetos",9.0),
                new CEstudiante("Juan", "5875", "Programacion basica",5.0),
                new CEstudiante("Susana", "A432", "Mercadotecnia",8.7),
                new CEstudiante("Pablo", "A156", "Mercadotecnia",4.3),
                new CEstudiante("Ana", "A100", "Mercadotecnia",8.0)
            };

            int cantidad = (from e in estudiantes
                            where e.Promedio > 5
                            select e).Count();


            Console.WriteLine("La cantidad de aprobados es {0}", cantidad);

            Console.WriteLine("---------------");


            var aprobados = from e in estudiantes
                            where e.Promedio > 5
                            select e;

            foreach (CEstudiante est in aprobados)
                Console.WriteLine(est);

            Console.WriteLine("Orden inverso");

            foreach (CEstudiante est in aprobados.Reverse())
            {
                Console.WriteLine(est);
            }

            //ordenamiento
            Console.WriteLine("ordenamiento");

            var ordenados = from e in estudiantes
                            orderby e.Promedio descending
                            select e;

            foreach (CEstudiante est in ordenados)
                Console.WriteLine(est);

            Console.WriteLine("Ascendente");

            var ordenadosA = from e in estudiantes
                             orderby e.Promedio ascending
                             select e;

            foreach (CEstudiante est in ordenadosA)
                Console.WriteLine(est);

            //agragacion

            int[] numeros = { 2, 5, 3, 9, 1, 6, 4, 7, 8 };

            Console.WriteLine("--------------------");

            int maximo = (from n in numeros select n).Max();
            Console.WriteLine("El maximo es {0}", maximo);

            int minimo = (from n in numeros select n).Min();
            Console.WriteLine("El minimo es {0}", minimo);

            double prom = (from n in numeros select n).Average();
            Console.WriteLine("El promedio es {0}", prom);

            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine("La sumatoria es {0}", sumatoria);

        }

    }
}
