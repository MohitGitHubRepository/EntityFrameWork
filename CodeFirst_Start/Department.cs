using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Start
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
        public string DepartmentStrength { get; set; }
        
        public virtual ICollection<Employee> employees { get; set; }
    }
}
