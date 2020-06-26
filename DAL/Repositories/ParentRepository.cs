using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    class ParentRepository : IRepository<Parent>
    {
        private readonly DbSet<Parent> _dbSet;
        public ParentRepository(ApplicationDbContext context)
        {
            _dbSet = context.Set<Parent>();
        }
        public void Add(Parent parent)
        {
            _dbSet.Add(parent);
        }
        public IEnumerable<Parent> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(Parent parent)
        {
            _dbSet.Update(parent);
        }
    }
}
