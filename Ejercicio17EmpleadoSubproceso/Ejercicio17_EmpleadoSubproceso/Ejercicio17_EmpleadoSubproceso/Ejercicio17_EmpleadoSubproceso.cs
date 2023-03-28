using System;
using System.Linq;

namespace Ejercicio17_EmpleadoSubproceso
{
    public class Ejercicio17_EmpleadoSubproceso
    { 
        public const decimal SALARIO_MINIMO = 1160000;
    
        static void Main(string[] args)
        {
            // Ejercicio 17: Elaborar un programa que entre el nombre de un empleado, su salario básico por hora y el número de horas trabajadas en el mes;
            //escriba su nombre y salario mensual si éste es mayor del salario mínimo, de lo contrario escriba sólo el nombre.

            //DATOS DE ENTRADA --> nombreEmpleado, salrio, horaslaboras, salarioMin
            //DATOS DE SALIDA --> nombreEmpleado, salario

            string nombre;
            decimal valorhora, horasLaboradas, salario;

            // Subproceso/Subprograma/funcion/método
            // Estructura:

            // Modificador de acceso + Tipo de dato que retorna + Nombre del Método + Lista de parámetros
            // Ejemplo:
            // private/public + int/string/bool/decimal... + Name + (parámetro1, parámetro2, ... parámetroN)

            // Características: El método puede enviar o no enviar parámetros (vacio)
            //                  El método puede retornar un valor o no retornar nada - Void 

            //Vamos a crear 3 nuevos métodos:
            // 1. Que pida los datos
            // 2. Que calcule el salario
            // 3. Que muestre el resultado

            PedirDatos (out nombre,  out horasLaboradas,  out valorhora);
            salario = CalcularSalario(horasLaboradas, valorhora);
            MostrarResultado(nombre, salario,horasLaboradas,valorhora); 

        }

       static public void PedirDatos ( out string nombre, out  decimal horasLaboradas, out  decimal valorhora)
        {
            Console.Write("Por favor ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Por favor ingrese número de horas trabajadas del empleado: ");
            horasLaboradas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Por favor ingrese el valor por hora: ");
            valorhora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
        }

        static public decimal CalcularSalario(decimal horasLaboradas, decimal valorhora)
        {
            return horasLaboradas * valorhora; 
        }

       static public void MostrarResultado(string nombre, decimal salario, decimal horasLaboradas, decimal valorhora) 
        {
            if (salario > SALARIO_MINIMO)
            {
                Console.WriteLine(String.Format("Horas laboradas: {0} ", horasLaboradas));
                Console.WriteLine(String.Format("Valor hora: {0:C} ", valorhora));
                Console.WriteLine("");
                Console.WriteLine(String.Format("El empleado {0} se gana un salario de {1:C}", nombre, salario));
            }
            else
            {
                Console.WriteLine("El empleado se llama {0}", nombre);
            }
        }
    }
}