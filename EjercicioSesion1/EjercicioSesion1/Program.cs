using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

            DateTime horaActual = DateTime.Now;

            // Escribe la hora por pantalla
            Console.WriteLine("La hora actual es: " + horaActual.ToString("HH:mm:ss"));


        }
    }

}
