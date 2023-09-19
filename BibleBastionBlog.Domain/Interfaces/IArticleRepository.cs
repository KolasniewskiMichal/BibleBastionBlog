using BibleBastionBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Domain.Interfaces
{
    public interface IArticleRepository
    {
        Task Create(Article article);        

    }
}
