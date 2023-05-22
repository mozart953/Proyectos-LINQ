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

            IEnumerable<string> r3 = from p in postres
                                     where p.EndsWith("manzana")
                                     select p;

            foreach (string postre in r3)
                Console.WriteLine(postre);

            Console.WriteLine("-------------------------");

            Console.WriteLine("---TakeWhile----------\r\n");

            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };
            var r4 = numeros.TakeWhile(n => n < 8);


            foreach (int n in r4)
                Console.WriteLine(n);

            Console.WriteLine("-------------------------");

            var r5 = numeros.SkipWhile(n => n < 8);

            foreach (int n in r5)
                Console.WriteLine(n);

            Console.WriteLine("-------------------------");

            Console.WriteLine("-----Proyeccion indexada-------\r\n");

            IEnumerable<string> r6 = postres.Select((p, i) => "Indice " + i + " para el postre " + p);

            foreach (string n in r6)
                Console.WriteLine(n);

            Console.WriteLine("--------------------");

            Console.WriteLine("-----select many-------\r\n");

            IEnumerable<string> r7 = postres.SelectMany(p => p.Split());

            foreach (string n in r7)
                Console.WriteLine(n);

            Console.WriteLine("--------------------");


            Console.WriteLine("Comparamos con Select");

            IEnumerable<string[]> r8 = postres.Select(p => p.Split());

            foreach(string[] n in r8)
            {
                Console.WriteLine("-");
                foreach (string m in n)
                    Console.WriteLine(m);
            }

            Console.WriteLine("--------------------");


            Console.WriteLine("Select con multiples variables");

            IEnumerable<string> r9 = from p in postres
                                     from p1 in p.Split()
                                     select p1 + "===>" + p;

            foreach (string n in r9)
                Console.WriteLine(n);

            Console.WriteLine("------------");

            IEnumerable<string> r10 = from p in postres
                                      from p1 in postres
                                      select "Yo quiero: " + p1 + " y tu quieres: " + p;

            foreach(string n in r10)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("---------Join----------");

            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana", 100),
                new CEstudiante("Mario", 150),
                new CEstudiante("Susana", 150)

            };
            List<CCurso> cursos = new List<CCurso>
            {
                new CCurso("Programacion", 100),
                new CCurso("Orientacion objetos", 150),
                new CCurso("Programacion", 150),
                new CCurso("Programacion", 150),
                new CCurso("UML", 100),
                new CCurso("Orientacion Objetos", 150),
                new CCurso("UML", 100),

            };

            /*
             var listado= from e in estudiantes
                          from c in cursos
                          where c.Id == e.Id
                          select e.Nombre + "esta en el curso" + c.Curso;
             
             */

            var listado = from e in estudiantes
                          join c in cursos on e.Id equals c.Id 
                          select e.Nombre + " esta en el curso " + c.Curso;


            foreach (string n in listado)
                Console.WriteLine(n);


            Console.WriteLine("-------------------");
            Console.WriteLine("---------GroupJoin----------");

            var listado2 = from e in estudiantes
                           join c in cursos on e.Id equals c.Id
                           into tempListado
                           select new { estudiante = e.Nombre, tempListado };

            foreach(var lst in listado2)
            {
                Console.WriteLine(lst.estudiante);

                foreach (var list2 in lst.tempListado)
                    Console.WriteLine(list2);
            }

            Console.WriteLine("----ZIP --- \r\n");

            string[] helados = { "chocolate", "vainilla", "fresa", "limon" };

            IEnumerable<string> r12 = postres.Zip(helados, (p, h) => p + " con helado de " + h);

            foreach (string n in r12)
                Console.WriteLine(n);


            Console.WriteLine("------------Ordenamiento------\r\n");

            IEnumerable<int> numOrder = numeros.OrderBy(n => n);
            IEnumerable<int> numDes = numeros.OrderByDescending(n => n);

            foreach (int n in numOrder)
                Console.WriteLine(n);

            Console.WriteLine("--------------------");

            foreach (int n in numDes)
                Console.WriteLine(n);

            Console.WriteLine("--------------------");

            string[] palabras = { "hola", "piedra", "pasto", "pastel", "carros", "auto" };

            IEnumerable<string> palabrasOrd = palabras.OrderBy(p => p.Length).ThenBy(p => p);

            foreach(string n in palabrasOrd)
            {
                Console.WriteLine(n);
            }

            //Console.WriteLine("-----Agrupamiento ---\r\n");

            //string[] archivos = System.IO.Directory.GetFiles("c:\\Linter");

            //Console.WriteLine("Archivos obtenidos por GetFiles");

            //foreach (string n in archivos)
            //{
            //    Console.WriteLine(n);
            //}

            //var archivoAg = archivos.GroupBy(a => System.IO.Path.GetExtension(a));

            //Console.WriteLine("Resultados agrupados");

            //foreach (IGrouping<string, string> g in archivoAg)
            //{
            //    Console.WriteLine("Archivos de extension {0}", g.Key);
            //    foreach (string e in g)
            //        Console.WriteLine("\t {0}", e);
            //}

            Console.WriteLine("----De elemento ----\r\n");

            int primero = numeros.First();
            Console.WriteLine(primero);

            int primeroc = numeros.First(n => n % 2 == 0);
            Console.WriteLine(primero);

            int primerod = numeros.FirstOrDefault(n => n % 57 == 0);
            Console.WriteLine(primerod);

            Console.WriteLine("----De agregacion ----\r\n");

            int sumatoria = numeros.Sum();
            Console.WriteLine(sumatoria);

            int[] numeros2 = { 1, 2, 3, 4, 5 };

            int agregado = numeros2.Aggregate(0, (t, n) => t + (n * 2));

            Console.WriteLine(agregado);


            Console.WriteLine("----Cuantificadores----\r\n");

            bool todos = numeros2.All(n => n < 10);
            Console.WriteLine(todos);

            bool iguales = numeros2.SequenceEqual(numeros);
            Console.WriteLine(iguales);

            //Generacion
            Console.WriteLine("------Generacion----\r\n");

            var vacia = Enumerable.Empty<int>();

            foreach (int n in vacia)
                Console.WriteLine(n);

            Console.WriteLine("----------------");

            var repetir = Enumerable.Repeat("hola ", 5);

            foreach (string n in repetir)
                Console.WriteLine(n);

            var rango = Enumerable.Range(5, 15);

            foreach (int n in rango)
                Console.WriteLine(n);









        }
    }
}
