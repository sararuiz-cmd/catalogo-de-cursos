using System;
using System.Collections.Generic;
namespace CatalogoCursos
{
    

    class Program
    {
        static void Main(string[] args)
        {
            // Lista de cursos
            //modificado
            List<Curso> cursos = new List<Curso>
            {
                new Curso(1, "Algoritmos I", "Informática", "Fundamentos de algoritmos y lógica."),
                new Curso(2, "Introducción a la Programación", "Informática", "Primeros pasos en programación."),
                new Curso(3, "Matemática Discreta", "Matemáticas", "Conjuntos, lógica y grafos."),
                new Curso(4, "Bases de Datos", "Informática", "Modelo relacional y SQL."),
                new Curso(5, "Estructuras de Datos", "Informática", "Listas, pilas y árboles.")
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
                        Console.WriteLine(" Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine(" Opción no válida.\n");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}



