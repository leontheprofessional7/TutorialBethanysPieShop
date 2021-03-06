﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialBethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryId=1, CategoryName="Fruit pies", Description="AA-f" },
                    new Category { CategoryId=2, CategoryName="Cheese cakes", Description="Che" },
                    new Category { CategoryId=3, CategoryName="Fruit pies", Description="Ge"},
                    new Category { CategoryId=4, CategoryName="Seasonal pies", Description="Ge"}
                };
            }
        }
    }
}
