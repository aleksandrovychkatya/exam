using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ChildDTO
    {
        public string AllName { get; set; }
        public int Age { get; set; }
        List<ParentDTO> ListOfParents { get; set; }
    }
}
