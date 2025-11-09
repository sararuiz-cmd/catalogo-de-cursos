using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogoCursos
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Descripcion { get; set; }

        public Curso(int id, string nombre, string area, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Area = area;
            Descripcion = descripcion;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Datos iniciales de ejemplo
            var cursos = new List<Curso>
            {
                new Curso(1, "Introducción a C#", "Programación", "Curso básico de C#"),
                new Curso(2, "Bases de Datos", "Sistemas", "Conceptos de bases de datos relacionales"),
                new Curso(3, "Algoritmos y Estructuras", "Programación", "Algoritmos fundamentales")
            };

            Console.WriteLine("===================================");
            Console.WriteLine("     Catálogo de Cursos - V1.0     ");
            Console.WriteLine("===================================\n");
            Console.WriteLine($"Total de cursos disponibles: {cursos.Count}\n");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú principal:");
                Console.WriteLine("1. Mostrar todos los cursos");
                Console.WriteLine("2. Buscar curso por nombre");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        MostrarCursos(cursos);
                        break;

                    case "2":
                        BuscarCurso(cursos);
                        break;

                    case "3":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MostrarCursos(List<Curso> cursos)
        {
            if (cursos == null || cursos.Count == 0)
            {
                Console.WriteLine("No hay cursos registrados.\n");
                return;
            }

            Console.WriteLine($"Listado de cursos ({cursos.Count}):\n");
            foreach (var c in cursos)
            {
                Console.WriteLine($"[{c.Id}] {c.Nombre} - {c.Area}");
                Console.WriteLine($" Descripción: {c.Descripcion}\n");
            }
        }

        static void BuscarCurso(List<Curso> cursos)
        {
            if (cursos == null || cursos.Count == 0)
            {
                Console.WriteLine("Aún no hay cursos registrados para buscar.\n");
                return;
            }

            Console.Write("Ingrese texto para buscar: ");
            string filtro = Console.ReadLine()?.ToLower() ?? "";

            var resultados = cursos
                .Where(c => c.Nombre != null && c.Nombre.ToLower().Contains(filtro))
                .ToList();

            if (resultados.Count > 0)
            {
                Console.WriteLine($"\nResultados encontrados ({resultados.Count}):\n");
                foreach (var curso in resultados)
                {
                    Console.WriteLine($"[{curso.Id}] {curso.Nombre} - {curso.Area}");
                    Console.WriteLine($" Descripción: {curso.Descripcion}\n");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron cursos con ese nombre.\n");
            }
        }
    }
}
