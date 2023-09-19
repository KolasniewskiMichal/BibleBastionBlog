using BibleBastionBlog.Application.Dtos;

namespace BibleBastionBlog.Application.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategories();
        Task Create(CategoryDto categoryDto);
    }
}