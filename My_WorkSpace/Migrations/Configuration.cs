namespace My_WorkSpace.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<My_WorkSpace.Models.WorkSpace>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "My_WorkSpace.Models.WorkSpace";
        }

        protected override void Seed(My_WorkSpace.Models.WorkSpace context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
