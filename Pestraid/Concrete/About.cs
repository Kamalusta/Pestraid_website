using Entities.Abstract;

namespace Entities.Concrete
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }

    }
}
