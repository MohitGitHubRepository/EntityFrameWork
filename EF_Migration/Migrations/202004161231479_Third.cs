namespace EF_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {

            DropColumn("dbo.Departments", "DepartmentHod");
        }
        
        public override void Down()
        {
        }
    }
}
