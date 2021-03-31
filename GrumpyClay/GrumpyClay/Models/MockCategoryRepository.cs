using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                    CategoryId = 1, 
                    CategoryName = "Original",
                    Description = "Original creation"
                },
                new Category
                {
                    CategoryId = 2, 
                    CategoryName = "Cartoon", 
                    Description = "Cartoon inspired creation"
                },
                new Category
                {
                    CategoryId = 3, 
                    CategoryName = "Video Game", 
                    Description = "Video game inspired creation"
                }
            };
    }
}
