using System;

namespace Ejercicio13CicloFor
{
    public class Ejercicio13CicloFor
    {
        static void Main(string[] args)
        {
            //Un algoritmo que permita ingresar N datos correspondientes al género de N número de personas y determine el porcentaje de hombres y mujeres que hay

            string firstName, lasName, gender;
            float percentageMale, percentageFemale, persons;
            int i, counterMale = 0, counterFemale = 0;

            Console.Write("¿Cuántas personas quieres ingresar? ");
            persons = Convert.ToInt32(Console.ReadLine());
            Console.Write("");

            for (i = 0; i < persons; i++)
            {
                Console.Write("Nombre: ");
                firstName = Console.ReadLine();
                Console.Write("");

                Console.Write("Apellido:");
                lasName = Console.ReadLine();
                Console.Write("");

                Console.Write("Digite M para masculino o F para femenino: ");
                gender = Console.ReadLine();
                Console.Write("");

                if (gender == "M" || gender == "m") counterMale++;
                else counterFemale++;
            }

            percentageMale = (counterMale / persons) * 100;
            percentageFemale = (counterFemale / persons) * 100;

            Console.WriteLine($"El porcentaje de hombres es: { String.Format("{0:0.##}", percentageMale) } %");
            Console.WriteLine($"El porcentaje de mujeres es: {String.Format("{0:0.##}", percentageFemale) }%");
        }
    }
}
