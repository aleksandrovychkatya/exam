using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Group: BaseEntity
    {
        public string Name { get; set; }
        public Teacher TeacherInGroup { get; set; }
        List<Child> ListOfChildren { get; set; }
    }
}
