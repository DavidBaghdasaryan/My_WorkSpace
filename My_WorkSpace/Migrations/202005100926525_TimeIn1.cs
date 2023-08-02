namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeIn1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "TimeIn", c => c.String());
            AlterColumn("dbo.Employees", "TimeOut", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "TimeOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "TimeIn", c => c.DateTime(nullable: false));
        }
    }
}
