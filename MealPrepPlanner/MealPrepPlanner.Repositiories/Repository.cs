using MealPrepPlanner.Entities;
using MealPrepPlanner.Repositiories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MealPrepPlanner.Repositiories
{
    public class Repository : IRepository
    {
        protected readonly DbContext _context;
        protected DbSet<Meal> _dbSet;

        public Repository(MealPrepPlannerContext context)
        {
            _context = context;
            _dbSet = context.Set<Meal>();
        }

        public IEnumerable<Meal> GetAllMeals()
        {
            return _dbSet;
        }
    }
}
