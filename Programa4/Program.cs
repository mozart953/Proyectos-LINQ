using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
                new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
                new CEstudiante("Juan","5875", "Programacion basica", 5.0),
                new CEstudiante("Susana","A432", "Mercadotecnia", 8.7),
                new CEstudiante("Alberto","5456", "Orientado a objetos", 8.3)

            };

            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0
                             select e;

            Console.WriteLine("Reprobados");

            foreach(CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }


            Console.WriteLine("solo un atributo");
            foreach(CEstudiante r in reprobados)
            {
                Console.WriteLine(r.Nombre);
            }

            var mercadotecnia = from e in estudiantes
                                where e.Curso== "Mercadotecnia"
                                select e.Nombre;

            Console.WriteLine("Nombres de mercadotecnia");
            foreach(string n in mercadotecnia)
            {
                Console.WriteLine(n);
            }





        }
    }
}
