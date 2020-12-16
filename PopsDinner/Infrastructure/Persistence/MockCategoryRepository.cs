using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
using popsDiner.Domain.Repository;
namespace popsDiner.Infrastructure.Persistence
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId=1, CategoryName="Burgers", Description="",},
                    new Category {CategoryId=2, CategoryName="Drinks", Description=""},
                    new Category {CategoryId=3, CategoryName="Combos", Description=""}
                };
            }
        }
    }
}
