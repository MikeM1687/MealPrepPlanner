using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using MealPrepPlanner.Entities;
using MealPrepPlanner.Client;
using System.Threading;

namespace MealPrepPlanner.Tests.RestClientTests
{
    public class RestClientTests
    {
        private Uri uri = new Uri("http://localhost:5000");

        [Fact]
        public void GetAllMealsAsync_ReturnsAllMeals()
        {
            var meals = MealsTestData();
            var client = new RestClient(uri);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            var mockHttpResponse = new MockMessageHandler().GetMockClient();

            var result = client.GetMeals(token).Result;

            Assert.NotNull(result);
        }

        private List<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal { Id = 1, Name = "Meal 1" },
                new Meal { Id = 2, Name = "Meal 2" },
                new Meal { Id = 3, Name = "Meal 3" }
            };
        }
    }
}
