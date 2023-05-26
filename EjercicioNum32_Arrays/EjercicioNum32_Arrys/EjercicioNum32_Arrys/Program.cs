using System;

namespace EjercicioNum32_Arrys
{
 
    public class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 32. Pedir N números por pantalla y guardarlos en vector. Mostrar el número máximo y el número mínimo..


            int m, max, min;

            Console.Write("\nPor favor digite el tamaño del vector   : ");
            m = Convert.ToInt32(Console.ReadLine());

            //Declaración de 2 arrays
            int[] arrayN = new int[m];

            AskData(m, arrayN);
            GenerateMaxMin(arrayN);
            //ShowsResults(max, min);


        }
        public static void AskData(int m, int[] arrayN)
        {
            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.Write("\nPor favor digite un: número :");
                arrayN[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void GenerateMaxMin(int[] arrayN)

        {
            int max, min;
            max = 0;
            min = arrayN[0];
            for (int i = 0; i < arrayN.Length; i++)
            {
                //Console.WriteLine(("\n El vector resultante es:", arrayN[i]));
                if (arrayN[i] > max)
                {
                    max = arrayN[i];

                }
                if (arrayN[i] < min)
                {
                    min = arrayN[i];
                }
            }
            Console.WriteLine(("\n El máximo valor es:", max));
            Console.WriteLine(("\n El mínimo valor es:", min));
        }

        //public static void ShowsResults(int max, int min)
        //{

        //Console.WriteLine(("\n El máximo valor es:", max));
        // Console.WriteLine(("\n El mínimo valor es:", min));
        //}



    }

}