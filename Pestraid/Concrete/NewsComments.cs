using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class NewsComments
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int NewsId { get; set; }
        public int CommentId { get; set; } = 0;
    }
}
