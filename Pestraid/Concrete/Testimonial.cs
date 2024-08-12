using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Testimonial : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Rate { get; set; }
        public string PhotoUrl { get; set; }
    }
}
