using AutoMapper;
using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Domain.Entities;
using BibleBastionBlog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Create(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);

            await _categoryRepository.Create(category);

        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            var dtos = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return dtos;
        }
    }
}
