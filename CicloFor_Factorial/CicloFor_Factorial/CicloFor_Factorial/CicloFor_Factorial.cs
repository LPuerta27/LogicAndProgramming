using System;

namespace CicloFor_Factorial
{
    public class CicloFor_Factorial
    {
        static void Main(string[] args)
        {
            // Ejemplo 12: Desarrolle un algoritmo que pida por pantalla N números y calcule la factorial de ellos.

            double n, i, factorial = 1;

            Console.Write("Digite el número n (tope): ");
            n= Convert.ToDouble(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("El factorial de: " + n + " es: " + factorial);

        }
    }
}
