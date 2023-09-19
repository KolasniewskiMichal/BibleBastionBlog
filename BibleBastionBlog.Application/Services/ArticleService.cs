using AutoMapper;
using BibleBastionBlog.Application.Dtos;
using BibleBastionBlog.Domain.Entities;
using BibleBastionBlog.Domain.Helpers;
using BibleBastionBlog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task Create(ArticleDto articleDto)
        {
            var article = _mapper.Map<Article>(articleDto);

            article.EncodeTitle();
            await _articleRepository.Create(article);
           
        }

    }
}
