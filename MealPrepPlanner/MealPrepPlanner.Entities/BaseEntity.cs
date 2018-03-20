using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id
        {
            get;
            set;
        }
    }

    public interface IBaseEntity
    {
        int Id
        {
            get;
            set;
        }
    }
}
