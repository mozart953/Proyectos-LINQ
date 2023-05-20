using System;
using System.Collections;
using System.Linq;

namespace proyecto5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.AddRange(new object[] { "hola", 5, 6, 7, false, 4, 2, "saludo", 3.5, 3 });

            var enteros = lista.OfType<int>();
            foreach (int n in enteros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------------");

            ArrayList estudiantes = new ArrayList()
            {
                new Programa5.CEstudiante("Ana", "A100", "Mercadotecnia",10.0),
                new Programa5.CEstudiante("Luis", "5250", "Orientacion a objetos",9.0),
                new Programa5.CEstudiante("Juan", "5875", "Programacion basica",5.0),
                new Programa5.CEstudiante("Susana", "A432", "Mercadotecnia",8.7),
                new Programa5.CEstudiante("Pablo", "A156", "Mercadotecnia",4.3),
                new Programa5.CEstudiante("Ana", "A100", "Mercadotecnia",8.0)
            };

            var estL = estudiantes.OfType<Programa5.CEstudiante>();

            var reprobados = from e in estL
                             where e.Promedio <= 5.0
                             select e;

            Console.WriteLine("Reprobados");

            foreach(Programa5.CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }

            //proyeccion

            var nombrePromedio = from e in estL
                                 select new { e.Nombre, e.Promedio };

            foreach(var np in nombrePromedio)
            {
                Console.WriteLine(np.ToString());
            }
        }
    }
}
