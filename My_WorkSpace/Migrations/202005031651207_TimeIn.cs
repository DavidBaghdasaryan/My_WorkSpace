namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeIn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "TimeIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "TimeOut", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "Overtime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Overtime");
            DropColumn("dbo.Employees", "TimeOut");
            DropColumn("dbo.Employees", "TimeIn");
        }
    }
}
