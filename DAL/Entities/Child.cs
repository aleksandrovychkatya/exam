using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Child: BaseEntity
    {
        public string AllName { get; set; }
        public int Age { get; set; }
        List<Parent> ListOfParents { get; set; }
    }
}
