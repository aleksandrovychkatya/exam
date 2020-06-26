using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ParentDTO : BaseDTO
    {
        public string AllName { get; set; }
        public string FatherOrMother { get; set; }
        public string Priority { get; set; }
        public string Telephone { get; set; }
    }
}
