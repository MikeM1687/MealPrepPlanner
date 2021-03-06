﻿using MealPrepPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlanner.Repositiories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
