using System.Collections.Generic;
using System.Linq;
using Bookshop.DAL;
using Bookshop.Logic.Contracts;
using Bookshop.Models;

namespace Bookshop.Logic
{
    public class BookRepository : Repository<Book>, IBookRepository
    {

        public IEnumerable<Person> GetPeopleByBookId(int id)
        {
            var query = from t1 in _db.Libraries
                        join t2 in _db.People
                        on t1.Id equals id
                        select new
                        {
                            Person = t2
                        };

            List<Person> people = query.Select(x => x.Person).ToList();
            return people;
        }
    }
}
