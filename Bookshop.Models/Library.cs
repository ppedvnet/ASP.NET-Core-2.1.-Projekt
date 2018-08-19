namespace Bookshop.Models
{
    public class Library : Entity
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
