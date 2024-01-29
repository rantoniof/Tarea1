
using System;

namespace Tarea1
{
    public class SuperHeroe
    {
        
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        // Constructor de la clase SuperHeroe
        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoder = superPoder;
        }

        // Método para mostrar la información del superhéroe
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {PuedeVolar}");
            Console.WriteLine($"SuperPoder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripción del SuperPoder: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel del SuperPoder: {SuperPoder.Nivel}");
            Console.WriteLine();
        }
    }
}
