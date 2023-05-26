using System;
using System.Security.Cryptography.X509Certificates;

namespace EjercicioNum33_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 33. Realizar un algoritmo que declare 3 arrays de 5 elementos cada uno.
            //Llenar el vector1 y vector2 y calcular vector3 = vector1 + vector2.


            int[] arrayVectorA = new int[5];
            int[] arrayVectorB = new int[5];



            AskData(arrayVectorA, arrayVectorB);
            ShowResults(arrayVectorA, arrayVectorB);
        }

        public static void AskData(int[] arrayVectorA, int[] arrayVectorB)
        {
            Console.WriteLine("********");
            Console.WriteLine("Vector A");
            Console.WriteLine("********");

            for (int i = 0; i < arrayVectorA.Length; i++)
            {
                Console.Write("\nIngrese el valor {0}: ", i+1, arrayVectorA[i]);
                arrayVectorA[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n********");
            Console.WriteLine("Vector B");
            Console.WriteLine("********");

            for (int i = 0; i < arrayVectorB.Length; i++)
            {
                Console.Write("\nIngrese el valor {0}: ", i+1, arrayVectorB[i]);
                arrayVectorB[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("");
            }

        }

            public static void ShowResults(int[] arrayVectorA, int[] arrayVectorB)
            { 
                int[] arrayVectorC = new int[5];

                Console.Write(String.Format("\nEl vector resultante es:"));
                Console.Write("\n[ ");
                for (int i = 0; i < arrayVectorC.Length; i++)
                {
                    arrayVectorC[i] = (arrayVectorA[i] + arrayVectorB[i]);

                    Console.Write(( "",arrayVectorC[i]));
                }
                    Console.WriteLine(" ]");
                    Console.WriteLine("\n");
            }
        
    }
}