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
    class TeacherRepository : IRepository<Teacher>
    {
        private readonly DbSet<Teacher> _dbSet;
        public TeacherRepository(ApplicationDbContext context)
        {
            _dbSet = context.Set<Teacher>();
        }
        public void Add(Teacher teacher)
        {
            _dbSet.Add(teacher);
        }
        public IEnumerable<Teacher> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(Teacher teacher)
        {
            _dbSet.Update(teacher);
        }
    }
}
