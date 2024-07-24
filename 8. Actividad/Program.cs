using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Actividad
{
    internal class Program
    {
        //Escribe un programa que genere un número aleatorio entre 1 y 100 y le pida al usuario que adivine el número.
        //El programa debe dar pistas al usuario (mayor que, menor que, igual) hasta que logre adivinar el número correcto.
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intento;
            int numeroIntentos = 0;
            bool adivinado = false;

            Console.WriteLine("Adivina el número (entre 1 y 100)");

            while (!adivinado)
            {
                // Solicitar al usuario que adivine el número
                Console.WriteLine("\nIngresa tu adivinanza: ");
                if (int.TryParse(Console.ReadLine(), out intento))
                {
                    numeroIntentos++;
                    if (intento < 1 || intento > 100)
                    {
                        Console.WriteLine("\nPor favor, ingresa un número entre 1 y 100.");
                    }
                    else if (intento < numeroAleatorio)
                    {
                        Console.WriteLine("\nEl número es mayor que " + intento);
                    }
                    else if (intento > numeroAleatorio)
                    {
                        Console.WriteLine("\nEl número es menor que " + intento);
                    }
                    else
                    {
                        Console.WriteLine($"\n¡Felicidades! Adivinaste el número correctamente en {numeroIntentos} intentos.");
                        adivinado = true;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida. Por favor, ingresa un número entero.");
                }
            }

            Console.WriteLine("\nGracias por jugar.");
            Console.ReadKey();
        }
    }
}
