using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Actividad
{
    internal class Program
    {
        //2. Escriba un programa que calcule las raíces de una ecuación de segundo grado cuyos coeficientes son a, b y c.
        //Utilice el método matemático Sqrt de la clase Math del espacio de nombres System,
        //que calcula la raíz cuadrada de un número que no puede ser negativo y aplicable sobre un tipo de dato double,
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes de la ecuación ax^2 + bx + c = 0");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"Las raíces son: {raiz1} y {raiz2}");
            }
            else if (discriminante == 0)
            {
                double raiz = -b / (2 * a);

                Console.WriteLine($"La raíz doble es: {raiz}");
            }
            else
            {
                Console.WriteLine("No hay raíces reales.");

                Console.ReadKey();
            }
        }
    }
}
