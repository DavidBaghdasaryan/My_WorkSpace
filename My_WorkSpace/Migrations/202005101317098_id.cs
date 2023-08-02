namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkSpaceEmplyes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeId = c.Int(nullable: false),
                        TimeIn = c.String(),
                        TimeOut = c.String(),
                        Overtime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkSpaceEmplyes");
        }
    }
}
