using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Entities
{
    public class MealPrepPlannerContext : DbContext
    {
        public MealPrepPlannerContext(DbContextOptions<MealPrepPlannerContext> options)
            : base(options) { }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
