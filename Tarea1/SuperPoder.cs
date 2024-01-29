using System;

namespace Tarea1
{
    public class SuperPoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }

        // Constructor de la clase SuperPoder
        public SuperPoder(string nombre, string descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }
    }
}