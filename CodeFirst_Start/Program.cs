  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Employee employee = new Employee() {
            //    Name="Mohit",
            //    Age="27",
            //    Dob="18-04-1993",
            //    DepartmentId=1
            //};

            ICollection<Employee> employees = new List<Employee>()
            {
                 new Employee() {
                Name="Kretee Arora",
                Age="27",
                Dob="14-04-1993" },
                 new Employee() {
                Name="Mohit Kumar",
                Age="26",
                Dob="18-04-1994" },

            };
            Department department = new Department()
            {
                DepartmentName = "Consultant",
                DepartmentStrength = "15",
                employees = employees

            };
            DBHelperClass context = new DBHelperClass();


            context.AddDepartment(department);
        //    context.AddEmployee(employee);
           // context.AddEmployeesToDepartment(employees, 1);

            Console.ReadKey();


        }
    }
}
