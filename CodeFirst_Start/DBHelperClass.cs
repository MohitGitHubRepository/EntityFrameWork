using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Start
{
    public class DBHelperClass
    {
        CFirstApproach1 context = new CFirstApproach1();

        public void AddDepartment(Department department)
        {
            context.department.Add(department);
            context.SaveChanges();
        }

        public void AddEmployee(Employee employee)
        {
            context.employee.Add(employee);
            context.SaveChanges();
        }

        public void AddEmployeesToDepartment(ICollection<Employee> employees,int id)
        {
            Department department = context.department.FirstOrDefault(a => a.DepartmentId == id);
            department.employees = employees;
            context.SaveChanges();
        }
    }
}
