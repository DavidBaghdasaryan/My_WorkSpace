namespace My_WorkSpace.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WorkSpace : DbContext
    {

        public WorkSpace()
            : base("name=WorkSpace")
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<WorkSpaceEmplyes> SpaceEmplyes { get; set; }
    }

    
}