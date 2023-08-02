namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Overtime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Overtime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Overtime", c => c.DateTime(nullable: false));
        }
    }
}
