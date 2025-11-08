// Clase base 
using System;

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
}
namespace CatalogoCursos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu principal

            Console.WriteLine("===================================");
            Console.WriteLine("     Catálogo de Cursos - V1.0     ");
            Console.WriteLine("===================================\n");

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

