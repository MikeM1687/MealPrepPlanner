using MealPrepPlanner.Entities;
using MealPrepPlanner.Repositiories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContextTransaction _transaction;
        private MealPrepPlannerContext _context { get; }

        public IRepository<Meal> MealRepository { get; }

        public UnitOfWork(MealPrepPlannerContext context, IRepository<Meal> mealRepository)
        {
            _context = context;
            MealRepository = mealRepository;
        }
    }
}
