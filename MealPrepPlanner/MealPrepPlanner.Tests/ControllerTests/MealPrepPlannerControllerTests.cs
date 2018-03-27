using MealPrepPlanner.Entities;
using MealPrepPlanner.Services.Interfaces;
using MeapPrepPlanner.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MealPrepPlanner.Tests.ControllerTests
{
    public class MealPrepPlannerControllerTests
    {
        [Fact]
        public void GetAllMeals_FromService_ReturnsAllMeals()
        {
            var meals = MealsTestData();

            var mockDataService = new Mock<IDataService>();

            mockDataService.Setup(x => x.GetMeals())
                .Returns(meals);

            var controller = new MealsController(mockDataService.Object);

            var result = controller.GetMeals();

            Assert.Equal(meals, result);
        }

        [Fact]
        public void GetAllIngredients_FromService_ReturnsAllIngredients()
        {
            var ingredients = IngredientsTestData();

            var mockDataService = new Mock<IDataService>();

            mockDataService.Setup(x => x.GetIngredients())
                .Returns(ingredients);

            var controller = new IngredientsController(mockDataService.Object);

            var result = controller.GetIngredients();
            var contentResult = result as OkObjectResult;

            Assert.Equal(ingredients, result);
        }

        private List<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal{Id = 1, Name = "Meal 1"},
                new Meal{Id = 2, Name = "Meal 2"},
                new Meal{Id = 3, Name = "Meal 3"},
            };
        }

        private List<Ingredient> IngredientsTestData()
        {
            return new List<Ingredient>
            {
                new Ingredient { Id = 1, Name = "Ingredient1"},
                new Ingredient { Id = 2, Name = "Ingredient2"},
                new Ingredient { Id = 3, Name = "Ingredient3"},
            };
        }
    }
}
