namespace EF_Migration.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Migration.CFirstApproach1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EF_Migration.CFirstApproach1";
        }

        protected override void Seed(EF_Migration.CFirstApproach1 context)
        {
            //  This method will be called after migrating to the latest version.




           //var departmentchnage= context.department.First(a => a.DepartmentId == 1);

           // departmentchnage.DepartmentHod = "Sivam Sharma";

           // context.SaveChanges();
        }
    }
}
