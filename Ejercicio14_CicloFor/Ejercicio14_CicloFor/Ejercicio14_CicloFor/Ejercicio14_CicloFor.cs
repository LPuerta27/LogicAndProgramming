using System;

namespace Ejercicio14_CicloFor
{
    internal class Ejercicio14_CicloFor
    {
        static void Main(string[] args)
        {
            // Ejemplo 14: Un algoritmo que permita mostrar los números primos existentes entre 1 y N

            int numbers, i;
            bool isPrime = true;

            Console.Write("Ingrese un tope: ");
            numbers = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= numbers; i++) 
            {
                isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 )
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"El número {i}  es primo");
                    Console.WriteLine("");
                }
            }
        }
    }
}
