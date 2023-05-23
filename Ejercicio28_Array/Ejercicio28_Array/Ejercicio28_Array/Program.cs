using System;
using System.Runtime.ConstrainedExecution;

namespace Ejercicio28_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 28. Realizar un algoritmo que solicite a un docente de clase ingresar las notas de los parciales de sus 5 estudiantes, que pueden ser 
            //valores enteros o con decimales. Adicional sacar el promedio general de las 5 notas y mostrar tanto las notas como el promedio en pantalla.

            //Declaración de un array
            double[] notes = new double[5];
            double sum = 0, avg=0;
            

            AskData( notes, sum );
            CalculateAverage( avg, sum, notes);
            ShowResults(avg, notes);

            static void AskData(  double notes,  double sum)
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    Console.WriteLine(String.Format("Por favor, ingrese la nota del estudiante {0}", i + 1));
                    notes[i] = Convert.ToDouble(Console.ReadLine());
                    sum = sum + notes[i];
                }
            }
            
            static void CalculateAverage( double avg,  double sum,  double notes)
            {
                avg = sum / notes.Length;
            }

            Console.Clear(); // Función: Borrar en pantalla lo que ya ingrese

            
            static void ShowResults( double avg,  double notes)
            {
                Console.WriteLine("NOTAS DE LOS ESTUDIANTES");

                for (int i = 0; i < notes.Length; i++)
                {
                    Console.WriteLine(String.Format("Estudiante {0}: Nota {1}", i + 1, notes[i]));
                }

                Console.WriteLine(String.Format("\nEl promedio general del grupo es de {0}", avg));
            }
            
        }
    }
}
