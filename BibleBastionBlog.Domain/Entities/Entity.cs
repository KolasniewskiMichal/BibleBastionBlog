using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBastionBlog.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set;}
        public DateTime CreatedAt { get; set;}
        public DateTime? UpdatedAt { get; set;}
        public DateTime? Inactivated { get; set;}
        public int StatusId { get; set;}

    }
}
