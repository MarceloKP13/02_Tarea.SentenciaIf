using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Tarea.Sentencia_If
{
    internal class Program
    {
        //1. Escriba un programa que a partir de tres valores enteros pedidos al usuario calcule su suma y su media.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un 1er número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un 2do número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un 3er número: ");
            int num3 = int.Parse(Console.ReadLine());

            int suma = num1 + num2 + num3;
            int media = (num1 + num2 + num3)/3;

            Console.WriteLine($"La suma de los 3 valores ingresado es: {suma}");
            Console.WriteLine($"La media de los valores es: {media}");

            Console.ReadKey();
        }
    }
}
