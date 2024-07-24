using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Actividad
{
    internal class Program
    {
        //6. Escribe un programa que solicite al usuario un número que represente un día de la semana
        //(1 para lunes, 2 para martes, etc.) y muestre el nombre completo del día correspondiente
        static void Main(string[] args)
        {
            Console.WriteLine("Eliga una opción: " +
                "\nDía 1 \nDía 2 \nDía 3 \nDía 4 \nDía 5 \nDía 6 \nDía 7");
            Console.Write("Su opción es: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (dia)
            {
                case 1:
                    Console.WriteLine("El día es LUNES");
                    break;
                case 2:
                    Console.WriteLine("El día es MARTES");
                    break;
                case 3:
                    Console.WriteLine("El día es MIÉRCOLES");
                    break;
                case 4:
                    Console.WriteLine("El día es JUEVES");
                    break;
                case 5:
                    Console.WriteLine("El día es VIERNES");
                    break;
                case 6:
                    Console.WriteLine("El día es SÁBADO");
                    break;
                case 7:
                    Console.WriteLine("El día es DOMINGO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
