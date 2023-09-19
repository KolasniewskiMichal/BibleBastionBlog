using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml.Linq;

namespace BibleBastionBlog.Domain.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public string EncodedTitle { get; private set; }
        public void EncodeTitle() => EncodedTitle = Title.ToLower().Replace(" ", "-");
    }
}
