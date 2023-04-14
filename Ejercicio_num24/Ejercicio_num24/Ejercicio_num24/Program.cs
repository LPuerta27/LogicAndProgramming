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
            //Datos de proceso: numDias, meses, anios
            //Datos de salida: numDias, dias, meses, años, anios

            decimal meses, anios, dias, diasRestantes;
            int numDias;

            PedirDatos(out numDias);
            Calcular(numDias, out anios, out meses, out dias);
            MostrarResultado(numDias, anios, meses, dias );
        


            static void PedirDatos(out  int numDias)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Por favor ingrese el número de días");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                numDias = Convert.ToInt32(Console.ReadLine());   
            }

            static void Calcular(  int numDias, out decimal meses, out decimal anios, out decimal dias)

            {
                decimal diasRestantes;
                
                anios = (numDias / 365);
                diasRestantes = (numDias % 365);
                meses = (diasRestantes / 30);
                dias = (diasRestantes % 30);

            }

            static void MostrarResultado (int numDias,  decimal meses,  decimal anios,decimal dias)

            {
                Console.WriteLine($"Tiene {anios.ToString(("0"))} años");
                Console.WriteLine($"Tiene {meses.ToString(("0"))} meses");
                Console.WriteLine($"Tiene {dias.ToString(("0"))} días");
            }
        }
    }
}
