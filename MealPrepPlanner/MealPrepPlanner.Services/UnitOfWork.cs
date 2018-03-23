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
        private MealPrepPlannerContext _context { get; }

        public IRepository<Meal> MealRepository { get; }
        public IRepository<Ingredient> IngredientRepository { get; }

        public UnitOfWork(MealPrepPlannerContext context,
            IRepository<Meal> mealRepository,
            IRepository<Ingredient> ingredientRepository)
        {
            _context = context;
            MealRepository = mealRepository;
            IngredientRepository = ingredientRepository;
        }
    }
}
