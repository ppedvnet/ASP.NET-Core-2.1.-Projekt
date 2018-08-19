using System.Collections.Generic;

namespace Bookshop.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Language Language { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
    }
}
