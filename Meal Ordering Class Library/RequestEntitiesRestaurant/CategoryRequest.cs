﻿using Meal_Ordering_Class_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal_Ordering_Class_Library.RequestEntitiesRestaurant
{
    public class CategoryRequest
    {
        public Category? Category { get; set; }
        public int? CategoryIdToDeleted { get; set; }
    }
}