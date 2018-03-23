using MealPrepPlanner.Entities;
using MealPrepPlanner.Repositiories.Interfaces;
using MealPrepPlanner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPrepPlanner.Services
{
    public class DataService<T> : IDataService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Meal> GetMeals()
        {
            return _unitOfWork.MealRepository.GetAll().ToList();
        }

        public List<Ingredient> GetIngredients()
        {
            return _unitOfWork.IngredientRepository.GetAll().ToList();
        }
    }
}
