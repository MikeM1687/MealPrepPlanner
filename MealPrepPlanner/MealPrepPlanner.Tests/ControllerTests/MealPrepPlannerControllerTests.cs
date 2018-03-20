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

            var controller = new MealPrepPlannerController(mockDataService.Object);

            var result = controller.Get();
            var contentResult = result as OkObjectResult;

            Assert.Equal(meals, contentResult.Value);
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
    }
}
