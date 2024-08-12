using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Review : BaseEntity
    {
        public string Content { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
    }
}
