using AutoMapper;
using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BibleBastionBlog.Application.Mappings
{
    public class BibleBastionBlogMappingProfile : Profile
    {
        public BibleBastionBlogMappingProfile()
        {
            CreateMap<ArticleDto, Article>();

            CreateMap<Article, ArticleDto>();

            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryDto>();

        }

    }
}
