using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Domain.Entities;

namespace BibleBastionBlog.Application.Services
{
    public interface IArticleService
    {
        Task Create(ArticleDto articleDto);
        Task<IEnumerable<Article>> GetAll();
    }
}