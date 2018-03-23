using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Units { get; set; }
    }
}
