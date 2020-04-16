using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Migration
{
    public class CFirstApproach1: DbContext 
    {

        public CFirstApproach1():base("CFirstApproach")
        {
            Database.CreateIfNotExists();
            
        }
        public DbSet<Employee> employee { get; set; }

        public DbSet<Department> department { get; set; }

    }
}
