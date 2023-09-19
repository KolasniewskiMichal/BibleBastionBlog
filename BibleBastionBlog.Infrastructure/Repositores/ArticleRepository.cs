using BibleBastionBlog.Application.Dtos;
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
    public class ArticleRepository : IArticleRepository
    {
        private readonly BibleBastionBlogDbContext _dbContext;
        public ArticleRepository(BibleBastionBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Article article)
        {
            _dbContext.Add(article);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Create(Category category)
        {
            _dbContext.Add(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
