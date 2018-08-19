using System;

namespace Bookshop.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime Added { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
