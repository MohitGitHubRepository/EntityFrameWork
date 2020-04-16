namespace EF_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentHod", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "DepartmentHod");
        }
    }
}
