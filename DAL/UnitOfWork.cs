using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<Child> ChildRepository { get; }
        public IRepository<Group> GroupRepository { get; }
        public IRepository<Parent> ParentRepository { get; }
        public IRepository<Teacher> TeacherRepository { get; }
        public UnitOfWork( ApplicationDbContext context, IRepository<Child> children,
           IRepository<Group> groups, IRepository<Parent> parents,
          IRepository<Teacher> teachers)
        {
            _context = context;
            ChildRepository = children;
            GroupRepository = groups;
            ParentRepository = parents;
            TeacherRepository = teachers;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
