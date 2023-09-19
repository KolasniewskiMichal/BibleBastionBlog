﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Domain.Entities
{
    public class Comment : Entity
    {
        public string Name { get; set; } = default!;
        public string Content { get; set; } = default!;
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
