using System;

namespace Ejercicio_num24
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar por pantalla un número de días y calcular cuántos años,meses y días tiene ese número ingresado.
              Tomar los meses con un estándar de 30 días.Hacer el programa con métodos*/

            //Datos de entrada: numDias
            //Datos de proceso: numDias, meses, años
            //Datos de salida: dias, meses, años

            decimal numDias, meses, anios;

            PedirDatos(out numDias);
            Calcular(numDias, out anios, out meses );


            static void PedirDatos(out decimal numDias)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Por favor ingrese el número de días");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                numDias = Convert.ToInt32(Console.ReadLine());   
            }

            static void Calcular(  decimal numDias, out decimal meses, out decimal anios)

            {
                anios = (numDias / 365);
                Console.WriteLine($"Tiene {anios} años  ");

                meses = (anios * 12);
                Console.WriteLine($"Tiene {meses} meses ");

                numDias = (meses * 30);
                Console.WriteLine($"Tiene {numDias}días");

            }



        }
    }
}
