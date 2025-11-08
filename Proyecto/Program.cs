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

