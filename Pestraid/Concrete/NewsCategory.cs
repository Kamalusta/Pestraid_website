using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class NewsCategory : BaseEntity
    {
        public string Name { get; set; }
    }
}
