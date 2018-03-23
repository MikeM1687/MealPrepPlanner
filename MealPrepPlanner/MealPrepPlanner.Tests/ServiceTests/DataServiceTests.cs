using System;
using Xunit;
using Moq;
using MealPrepPlanner.Entities;
using System.Collections.Generic;
using MealPrepPlanner.Repositiories.Interfaces;
using MealPrepPlanner.Services;
using System.Linq;

namespace MealPrepPlanner.Tests.DataServiceTests
{
    public class DataServiceTests
    {
        [Fact]
        public void GetAllMeals_ReturnsAllMeals()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var dataService = new DataService<Meal>(mockUnitOfWork.Object);

            mockUnitOfWork.Setup(x => x.MealRepository.GetAll())
                .Returns(MealsTestData());

            var meals = dataService.GetMeals();

            Assert.True(meals.Count() == MealsTestData().Count());
        }

        [Fact]
        public void GetAllIngredients_ReturnsAllIngredients()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var dataService = new DataService<Meal>(mockUnitOfWork.Object);

            mockUnitOfWork.Setup(x => x.IngredientRepository.GetAll())
                .Returns(IngredientsTestData());

            var ingredients = dataService.GetIngredients();

            Assert.True(ingredients.Count() == IngredientsTestData().Count());
        }

        private IEnumerable<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal{ Id = 1, Name = "Meal 1"},
                new Meal{ Id = 2, Name = "Meal 2"},
                new Meal{ Id = 3, Name = "Meal 3"}
            };
        }

        private IEnumerable<Ingredient> IngredientsTestData()
        {
            return new List<Ingredient>
            {
                new Ingredient {Id = 1, Name = "Ingredient 1"},
                new Ingredient {Id = 2, Name = "Ingredient 2"},
                new Ingredient {Id = 3, Name = "Ingredient 3"},
            };
        }
    }
}
