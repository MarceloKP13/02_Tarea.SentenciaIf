using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Actividad
{
    internal class Program
    {
        //5. Crea un programa que reciba la calificación numérica de un estudiante y
        //muestre la letra equivalente de la calificación (A, B, C, D, F) utilizando sentencias if.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su calificación: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 90 && nota <= 100)
            {
                Console.WriteLine("Su calificación equivale a: A");
            }
            else if (nota >= 80 && nota <= 89)
            {
                Console.WriteLine("Su calificación equivale a: B");
            }
            else if (nota >= 70 && nota <= 79)
            {
                Console.WriteLine("Su calificación equivale a: C");
            }
            else if (nota >= 60 && nota <= 69)
            {
                Console.WriteLine("Su calificación equivale a: D");
            }
            else if (nota <= 60 && nota >= 0)
            {
                Console.WriteLine("Su calificación equivale a: F");
            }
            else
            {
                Console.WriteLine("Nota NO válida");
            }
            Console.ReadKey();
        }
    }
}
