using MealPrepPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Repositiories.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Meal> MealRepository { get; }
        IRepository<Ingredient> IngredientRepository { get; }
    }
}
