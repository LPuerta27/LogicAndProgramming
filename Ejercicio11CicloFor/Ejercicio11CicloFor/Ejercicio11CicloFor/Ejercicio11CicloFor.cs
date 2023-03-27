using System;

namespace Ejercicio11CicloFor
{
    public class Ejercicio11CicloFor
    {
        static void Main(string[] args)
        {
            /* Ejercicio 11: Realice un pseudocódigo que itere los primeros N números naturales y me sume únicamente los que sean pares. */

            //DATOS DE ENTRADA --> int n, int suma 
            //PROCESO 
            //DATOS DE SALIDA <-- suma

            //Declaré unas variables (inicialize la variable suma
            int n, suma = 0, i;

            //Le pedí al usuario ingresar el tope por pantalla
            Console.Write("Por favor ingrese los primeros N números: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Hago la iteración
            //Primer item: Inicializa una variable controladora (casi siempre se inicializa en cero)
            //Segundo item: Me define hasta dónde quiero llegar (En este caso hasta n)
            //Tercer item: Me suma la variable iteradora (controladora) de 1 en 1 hasta llegar a n

            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                }
            }

            Console.Write("");
            Console.Write("La suma de los primeros " + n + " números pares es: " + suma);

        }
    }
}
