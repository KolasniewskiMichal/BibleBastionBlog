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
            //Tworzenie Artykułu
            CreateMap<ArticleDto, Article>()
                .ReverseMap()
                .ForMember(dest => dest.IsNew, conf => conf.MapFrom(model => DateTime.Now.Day - 7 > model.CreatedAt.Day ? true : false))
                .ForMember(dest => dest.IsUpdated, conf => conf.MapFrom(model => model.UpdatedAt.HasValue ? true : false));
        }
    }
}
