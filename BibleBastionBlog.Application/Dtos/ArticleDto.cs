using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BibleBastionBlog.Application.Dtos
{
    public class ArticleDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public bool IsUpdated { get; set; }
        public string? EncodedTitle { get; set; }

    }
}
