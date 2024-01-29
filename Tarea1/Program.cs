
namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos SuperPoder

            SuperPoder superPoder1 = new SuperPoder("Telequinesis", "Mover objetos con la mente", 5);
            SuperPoder superPoder2 = new SuperPoder("Vuelo", "Capacidad de volar", 8);
            SuperPoder superPoder3 = new SuperPoder("Fuerza sobrehumana", "Gran fuerza física", 7);

            // Crear objetos SuperHeroe usando el constructor
            SuperHeroe heroe1 = new SuperHeroe("Hombre Invisible", "John Doe", "Metrópolis", false, superPoder1);
            SuperHeroe heroe2 = new SuperHeroe("Superman", "Clark Kent", "Gotham", true, superPoder2);
            SuperHeroe heroe3 = new SuperHeroe("Hulk", "Bruce Banner", "Nueva York", false, superPoder3);

            // Mostrar información de los superhéroes
            heroe1.MostrarInformacion();
            heroe2.MostrarInformacion();
            heroe3.MostrarInformacion();

        }
    }
}
//hecho por: Ramon Flores
