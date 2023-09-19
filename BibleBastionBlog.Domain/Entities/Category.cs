using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; } = default!;
        public virtual ICollection<Article> Articles { get; set; }
    }
}
