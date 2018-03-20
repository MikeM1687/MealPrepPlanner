﻿using System;
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
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(x => x.GetAllMeals()).Returns(MealsTestData());

            var dataService = new DataService(mockRepo.Object);
            var meals = dataService.GetMeals();

            Assert.True(meals.Count() == MealsTestData().Count());
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
    }
}
