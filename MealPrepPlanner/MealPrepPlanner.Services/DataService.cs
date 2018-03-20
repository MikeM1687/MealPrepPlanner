using MealPrepPlanner.Entities;
using MealPrepPlanner.Repositiories.Interfaces;
using MealPrepPlanner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPrepPlanner.Services
{
    public class DataService : IDataService
    {
        private readonly IRepository _repo;

        public DataService(IRepository repo)
        {
            _repo = repo;
        }

        public List<Meal> GetMeals()
        {
            return _repo.GetAllMeals().ToList();
        }
    }
}
