﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Start
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Dob { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
