namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfieldintable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "TimeIn");
            DropColumn("dbo.Employees", "TimeOut");
            DropColumn("dbo.Employees", "Overtime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Overtime", c => c.String());
            AddColumn("dbo.Employees", "TimeOut", c => c.String());
            AddColumn("dbo.Employees", "TimeIn", c => c.String());
        }
    }
}
