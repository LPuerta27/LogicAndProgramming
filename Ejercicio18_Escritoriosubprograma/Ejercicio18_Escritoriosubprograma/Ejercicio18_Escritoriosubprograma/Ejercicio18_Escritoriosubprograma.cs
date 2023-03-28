using System;

namespace Ejercicio18_Escritoriosubprograma
{
    public class Ejercicio18_Escritoriosubprograma
    {
        public const decimal VALOR_ESCRITORIO = 650000;
        public const decimal DESCUENTO_1 = 0.1M;
        public const decimal DESCUENTO_2 = 0.2M;
        public const decimal DESCUENTO_3 = 0.4M;

        static void Main(string[] args)
        {
            // Ejercicio 18: Un almacén de escritorios hace los siguientes descuentos: si el cliente compra menos de 5 unidades se le da un descuento
            // del 10% sobre la compra;si el número de unidades es mayor o igual a cinco pero menos de 10 se le otorga un 20% y,si son 10 o más se le
            // da un 40%. Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorio es de $650.000.

            //Datos de entrada --> int numEscritorios, const valorEscritorio = 650000
            //Datos de salida  --> decimal precioFinal

            int numEscritorios;
            decimal precioFinal;

            PedirDatos(out numEscritorios);

            precioFinal = CalcularDescuentos (numEscritorios);

            MostrarResultado( precioFinal);
        }

        static void PedirDatos(out int numeroEscritorios)
        {
            Console.Write("Ingrese el número de escritorios a comprar: ");
            numeroEscritorios = Convert.ToInt32 (Console.ReadLine());
        }

        static decimal CalcularDescuentos (int numEscritorios)
        {
            decimal precioFinal;

            if (numEscritorios < 5 )
            {
                precioFinal = numEscritorios * VALOR_ESCRITORIO * (1 - DESCUENTO_1) ;
            }
            else if (numEscritorios >= 5  && numEscritorios < 10 )
            {
                precioFinal = numEscritorios * VALOR_ESCRITORIO * (1 - DESCUENTO_2);
            }
            else 
            {
                precioFinal = numEscritorios * VALOR_ESCRITORIO * (1 - DESCUENTO_3);
            }
            return precioFinal;
        }

        static void MostrarResultado(decimal precioFinal) 
        {
            Console.Write(String.Format("El valor final a pagar es de: {0:C}", precioFinal));
        }
    }
}
