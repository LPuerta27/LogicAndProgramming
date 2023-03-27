
/* Ejemplo 10: Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará 
 * alguna operación aritmética desde un menú.Si introduce 1 los números se deben sumar, si introduce 2 los números
 * se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero).
 * Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al 
 * menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa */

using System;
using System.ComponentModel;

namespace Calculadora
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            double num1, num2, sum, rest, prod, coci;
            int option = 1;
            string message = "Digite cualquier número para regresar al menú o 0 para finalizar";
            string lines = "----------------------";
            string divMessage = "La división es: ";
            ;
            while (option != 0)
            {
                Console.WriteLine(lines);
                Console.WriteLine("Calculadora Aritmética");
                Console.WriteLine(lines);
                Console.WriteLine("         Menú         ");
                Console.WriteLine(lines);
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Producto");
                Console.WriteLine("4. Cociente");
                Console.WriteLine("Digite 0 para salir");
                Console.WriteLine("");
                Console.Write("Ingrese una de las opciones del menú: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (option == 0)
                {
                    option = 0;
                }
                else if (option < 1 || option > 4)
                {
                    Console.WriteLine("Elige una opción válida del menú (teclee ENTER) ");
                    Console.ReadKey();
                    Console.WriteLine("");
                }
                else
                {

                    Console.Write("Ingresa el primer número:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Ingresa el primer número:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("¡Chao!");
                            break;

                        case 1:
                            sum = num1 + num2;
                            Console.WriteLine("La suma es: " + sum);
                            Console.WriteLine("");
                            break;

                        case 2:
                            rest = num1 - num2;
                            Console.WriteLine("La resta es: " + rest);
                            Console.WriteLine("");
                            break;

                        case 3:
                            prod = num1 * num2;
                            Console.WriteLine("La multiplicación es: " + prod);
                            Console.WriteLine("");
                            break;

                        case 4:
                            if (num1 == 0 && num2 == 0)
                            {
                                Console.WriteLine("División indeterminada");
                                Console.WriteLine("");
                            }
                            else if (num1 == 0)
                            {
                                coci = num1 / num2;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            else if (num2 == 0)
                            {
                                coci = num2 / num1;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            else
                            {
                                coci = num1 / num2;
                                Console.WriteLine(divMessage + coci);
                                Console.WriteLine("");
                            }
                            break;
                    }
                    Console.WriteLine(message);
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                }

                Console.Clear();
            }
            Console.WriteLine("Has finalizado la calculadora, ¡chao!");
        }
    }
}

