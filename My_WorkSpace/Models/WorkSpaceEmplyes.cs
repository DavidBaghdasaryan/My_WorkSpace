using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_WorkSpace.Models
{
   public class WorkSpaceEmplyes
    {
        public int Id { get; set; }
        public int EmployeId { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string Overtime { get; set; }
    }
}
