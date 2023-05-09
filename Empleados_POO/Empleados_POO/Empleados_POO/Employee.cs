﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_POO
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HiringDate { get; set; }
        public bool IsActive { get; set;}

    }
}
