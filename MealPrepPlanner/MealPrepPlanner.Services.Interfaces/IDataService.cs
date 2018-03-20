using MealPrepPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Services.Interfaces
{
    public interface IDataService
    {
        List<Meal> GetMeals();
    }
}
