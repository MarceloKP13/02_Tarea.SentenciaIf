using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Actividad
{
    internal class Program
    {
        //Crea un programa que simule un cajero automático. El programa debe solicitar al usuario la cantidad
        //de dinero que desea retirar y verificar si tiene saldo suficiente. Si tiene saldo suficiente,
        //se debe realizar la operación y actualizar el saldo.
        static void Main(string[] args)
        {
            double saldo = 2500.0;

            Console.WriteLine("Bienvenido al cajero automático.\n");
            Console.WriteLine($"Saldo disponible: ${saldo}\n");

            Console.Write("Ingrese la cantidad que desea retirar: $");
            double cantidadARetirar;

            if (double.TryParse(Console.ReadLine(), out cantidadARetirar))
            {
                if (cantidadARetirar <= 0)
                {
                    Console.WriteLine("Por favor, ingrese una cantidad válida mayor a 0.");
                }
                else if (cantidadARetirar > saldo)
                {
                    Console.WriteLine("\nError: Saldo insuficiente.");
                }
                else
                {
                    saldo -= cantidadARetirar;
                    Console.WriteLine($"\nRetiro exitoso. Cantidad retirada: ${cantidadARetirar}\n");
                    Console.WriteLine($"Nuevo saldo disponible: ${saldo}");
                }
            }
            else
            {
                Console.WriteLine("\nError: Entrada no válida. Por favor, ingrese un número.\n");
            }

            Console.WriteLine("\nGracias por utilizar el cajero automático. ¡Hasta luego!\n");
            Console.ReadKey();
        }
    }
}