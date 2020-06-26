using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class GroupDTO: BaseDTO
    {
        public string Name { get; set; }
        public TeacherDTO TeacherInGroup { get; set; }
        List<ChildDTO> ListOfChildren { get; set; }
    }
}
