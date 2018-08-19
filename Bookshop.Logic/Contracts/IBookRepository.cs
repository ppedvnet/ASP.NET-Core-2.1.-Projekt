using Bookshop.Models;
using System.Collections.Generic;

namespace Bookshop.Logic.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Person> GetPeopleByBookId(int id);
    }
}
