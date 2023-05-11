using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_POO
{
    public class CommissionEmployee : Employee

    {
        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        public decimal GetValueToPay()
        {
            return Sales * ((decimal)CommissionPercentage/100);
           
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine(String.Format("Empleado Por Comisión\n" +
                "ID: {0}\n" +
                "Nombres: {1}\n" +
                "Apellidos: {2}\n" +
                "Fecha de nacimiento: {3}\n" +
                "Fecha de contratación: {4}\n" +
                "Está activo: {5}\n" +
                "Ventas del mes: {6:C2} \n" +
                "Porcentaje de comisión: {7:P2}\n" +
                "Ingresos comisión: {8:C2}\n",
                Id, 
                FirstName, 
                LastName, 
                BirthDate, 
                HiringDate, 
                IsActive, 
                Sales, 
                CommissionPercentage/100, 
                GetValueToPay()));
        }
    }

     


}
