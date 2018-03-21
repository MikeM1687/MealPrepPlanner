using MealPrepPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MealPrepPlanner.Client
{
    public interface IRestClient
    {
        Task<IEnumerable<Meal>> GetMeals(CancellationToken token);
    }
}
