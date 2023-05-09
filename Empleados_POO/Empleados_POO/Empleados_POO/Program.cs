using System;

namespace Empleados_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar una aplicación de consola ( a través del paradigma POO) donde se desarrollará el cálculo de unos ingresos de los empleados, según su tipo.
            //Por ejempli: si es un empleado asalariado (SalaryEmployee),entonces simplemente definimos el salario que se gana mensual
            //Si es un empleado por prestación de servicios (HourlyEmployee), entonces calcular sus ingresos con base a las horas trabajadas vs el valor de la hora.
            //Si es unempleado por comisión (ComissionEmployee), entonces calcular sus ingresos con base al total de ventas del mes con respecto al porcentaje de comisión.
            //Mostar la información de cada uno de los empleados.


            //Nota: No es necesario instanciar la clase padre dedido a que accedo a lo que tenga mi papá a través de las hija

            //Declaració de variables
            int id;
            String firstName, lastName;
            DateTime birthDate, hiringDate;
            bool IsActive;
            decimal salary, sales;
            double commissionPercentage;


            //Instancio la clase SalaryEmployee (Doy vida a la clase)
            SalaryEmployee salaryEmployee = new SalaryEmployee();

            SalaryEmployee employee = new SalaryEmployee();

            Console.WriteLine("*************");
            Console.WriteLine("**EMPLEADOS**");
            Console.WriteLine("*************\n");

            Console.Write("Ingrese su ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su nombre: ");
            firstName= Console.ReadLine();

            Console.Write("Ingrese sus apellidos: ");
            lastName = Console.ReadLine();

            Console.Write("Ingrese su fecha de cumpleaños: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Ingrese su fecha de contratación: ");
            hiringDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("¿Es un empleado activo?: ");
            IsActive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingrese su salario: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n");

            //Asignar los valores capturados por pantalla a cada una de las propiedades del objeto SalaryEmployee

            salaryEmployee.Id = id;
            salaryEmployee.FirstName = firstName;
            salaryEmployee.LastName = lastName;
            salaryEmployee.BirthDate = birthDate;
            salaryEmployee.HiringDate = hiringDate;
            salaryEmployee.IsActive = IsActive;
            salaryEmployee.Salary= salary;

            salaryEmployee.ShowEmployeeInformation();

            Console.Write("Ingrese su ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su nombre: ");
            firstName = Console.ReadLine();

            Console.Write("Ingrese sus apellidos: ");
            lastName = Console.ReadLine();

            Console.Write("Ingrese su fecha de cumpleaños: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Ingrese su fecha de contratación: ");
            hiringDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("¿Es un empleado activo?: ");
            IsActive = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingrese las ventas del mes: ");
            sales = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de la comisión: ");
            commissionPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");

            //Instancio la clase CommissionEmployee (Doy vida a la clase)
            CommissionEmployee commissionEmployee = new CommissionEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = IsActive,
                Sales = sales,
                CommissionPercentage = commissionPercentage,

            };
            commissionEmployee.ShowEmployeeInformation();
        }
    }
}
