using System.Collections.Generic;

namespace Bookshop.Models
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Library> Libraries { get; set; }
    }
}
