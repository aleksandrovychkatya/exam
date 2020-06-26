using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ChildRepository : IRepository<Child>
    {
        private readonly DbSet<Child> _dbSet;
        public ChildRepository( ApplicationDbContext context)
        {
            _dbSet = context.Set<Child>();
        }

        public IEnumerable<Child> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(Child child)
        {
            _dbSet.Add(child);
        }
        public void Update(Child child)
        {
            _dbSet.Update(child);
        }
    }

}
