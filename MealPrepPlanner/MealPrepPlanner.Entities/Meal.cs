using System;
using System.Collections.Generic;

namespace MealPrepPlanner.Entities
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
