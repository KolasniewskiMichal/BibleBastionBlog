using BibleBastionBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Domain.Helpers
{
    public static class Categories
    {
        public static List<Category> GetAll()
        {
            return new List<Category>
            {
                new Category() { Id = 1, Name = "Test" },
                new Category() { Id = 2, Name = "Test2" },
                new Category() { Id = 3, Name = "Test3" }
            };
        }
    }
}