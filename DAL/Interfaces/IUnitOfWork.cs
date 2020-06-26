using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork 
    {
        IRepository<Child> ChildRepository { get; }
        IRepository<Group> GroupRepository { get; }
        IRepository<Parent> ParentRepository { get; }
        IRepository<Teacher> TeacherRepository { get; }
        void Save();
    }
}
