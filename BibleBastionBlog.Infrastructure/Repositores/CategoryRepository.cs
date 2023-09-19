using BibleBastionBlog.Domain.Entities;
using BibleBastionBlog.Domain.Interfaces;
using BibleBastionBlog.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Infrastructure.Repositores
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BibleBastionBlogDbContext _dbContext;
        public CategoryRepository(BibleBastionBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Category category)
        {
            _dbContext.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategories() 
            => await _dbContext.Categories.ToListAsync();
 
    }
}
