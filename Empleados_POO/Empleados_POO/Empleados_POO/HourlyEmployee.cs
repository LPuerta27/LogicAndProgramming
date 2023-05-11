using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_POO
{
    public class HourlyEmployee : Employee

    {
        public double Hours { get; set; }
        public decimal HourValue { get; set; }

        public decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;

        }
        public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Empleado Por Horas\n" +
                "ID: {0}\n" +
                "Nombres: {1}\n" +
                "Apellidos: {2}\n" +
                "Fecha de nacimiento: {3}\n" +
                "Fecha de contratación: {4}\n" +
                "Está activo: {5}\n" +
                "Horas trabajadas: {6} \n" +
                "Valor hora: {7:C2}\n" +
                "Ingresos: {8:C2}\n",
                Id,
                FirstName,
                LastName,
                BirthDate,
                HiringDate,
                IsActive,
                Hours,
                HourValue,
                GetValueToPay()));
        }
    }
}
