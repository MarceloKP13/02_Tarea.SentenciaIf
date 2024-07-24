using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Actividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nUsted tiene {edad} años.");
            if (edad < 0 || edad > 122)
            {
                Console.WriteLine("\nIngrese una edad válida (entre 0 y 122 años).");
            }
            else if (edad >= 16 && edad <= 17)
            {
                Console.WriteLine("\nTiene la opción de VOTAR O NO hacerlo");
            }
            else if (edad >= 18 && edad <= 64)
            {
                Console.WriteLine("\nEsta OBLIGADO a ejervcer el voto");
            } 
            else if (edad >= 65)
            {
                Console.WriteLine("\nTiene la opción de VOTAR O NO hacerlo");
            }
            else if (edad <= 15)
            {
                Console.WriteLine("\nEs demasiado joven para Votar");
            }
            Console.ReadKey();
        }
    }
}
