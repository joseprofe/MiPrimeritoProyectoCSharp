using MiPrimeritoProyectoCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiPrimeritoProyectoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            var alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("Pepe", 9, 10));
            alumnos.Add(new Alumno("Johny", 1, 8));
            alumnos.Add(new Alumno("Sami", 5, 3));
            alumnos.Add(new Alumno("Lily",8, 5));

            Console.WriteLine(alumnos.Average(a => a.Nota));
            Console.WriteLine(alumnos.Where(a => a.Nota >= 5));
            Console.WriteLine(alumnos.Max(a => a.Nota));
            Console.WriteLine(alumnos.OrderByDescending(a => a.DNI));

        }
    }
}
