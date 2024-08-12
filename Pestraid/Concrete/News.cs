using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateOnly Date { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}
