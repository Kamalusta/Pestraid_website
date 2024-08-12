using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Client { get; set; }
        public int Turnaround { get; set; }
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public string Projectinfo { get; set; }

        public string Benefits { get; set; }
        public string ProjectImageUrl { get; set; }
    }
}
