using MealPrepPlanner.Entities;
using MealPrepPlanner.Repositiories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MealPrepPlanner.Repositiories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected readonly DbContext _context;
        protected DbSet<T> _dbSet;

        public Repository(MealPrepPlannerContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
    }
}
