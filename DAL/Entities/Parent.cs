using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Parent : BaseEntity
    {
        public string AllName { get; set; }
        public string FatherOrMother { get; set; }
        public string Priority { get; set; }
        public string Telephone { get; set; }
    }
}
