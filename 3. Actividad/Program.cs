using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Actividad
{
    internal class Program
    {
        //3. Escriba un programa que represente una pequeña calculadora.
        //Para ello, el programa pedirá dos números enteros y una operación aritmética (que debe ser +, -, * o /)
        //y mostrará el resultado correspondiente
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operación aritmética:" +
                "\n+. Suma" +
                "\n-. Resta" +
                "\n*. Multiplicación" +
                "\n/. División");

            Console.Write("La opcion es: ");
            char operacion = Console.ReadLine()[0];

            double resultado = 0;
            bool operacionValida = true;

            switch (operacion)
            {
                case '+':
                    Console.WriteLine("+. Suma");
                    resultado = num1 + num2;
                    break;
                case '-':
                    Console.WriteLine("-. Resta");
                    resultado = num1 - num2;
                    break;
                case '*':
                    Console.WriteLine("*. Multiplicación");
                    resultado = num1 * num2;
                    break;
                case '/':
                    Console.WriteLine("/. División");
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                        operacionValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    operacionValida = false;
                    break;
            }

            if (operacionValida)
            {
                Console.WriteLine($"El resultado de la operación es: {resultado}");
            }

            Console.ReadKey();
        }
    }
}
