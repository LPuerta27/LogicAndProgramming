using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_POO
{
    public  class SalaryEmployee : Employee //Con esta notación genero Herencia desde la hija SalaryEmployee hasta el padre Employee
    {
        public decimal Salary { get; set; }

        public decimal GetValueToPay ()
        {
            return Salary;
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Empleado Asalariado:\n" +
                "ID: {0}\n" +
                "Nombres: {1}\n" +
                "Apellidos: {2}\n" +
                "Fecha de nacimiento: {3}\n" +
                "Fecha de contratación: {4}\n" +
                "Está activo: {5}\n" +
                "Salario: {6}\n", Id, FirstName, LastName,BirthDate, HiringDate, IsActive, Salary ));
        }
    }
}
