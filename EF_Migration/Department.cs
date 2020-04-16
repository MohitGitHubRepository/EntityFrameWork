using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Migration
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
        public string DepartmentStrength { get; set; }

        public string DepartmentHod { get;set; }
        
        public virtual ICollection<Employee> employees { get; set; }
    }
}
