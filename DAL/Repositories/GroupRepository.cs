using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using DAL.Interfaces;



namespace DAL.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        private readonly DbSet<Group> _dbSet;
        public GroupRepository(ApplicationDbContext context)
        {
            _dbSet = context.Set<Group>();
        }

        public IEnumerable<Group> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(Group group)
        {
            _dbSet.Add(group);
        }
        public void Update(Group group)
        {
            _dbSet.Update(group);
        }
    }
}
