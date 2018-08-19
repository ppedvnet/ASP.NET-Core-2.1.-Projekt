using System;
using System.Collections.Generic;
using System.Linq;
using Bookshop.DAL;
using Bookshop.Logic.Contracts;
using Bookshop.Models;

namespace Bookshop.Logic
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected BookshopDBContext _db = new BookshopDBContext();

        public void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _db.Set<T>().Add(entity);
        }

        public T FindById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(Book));

            _db.Set<T>().Remove(entity);
        }

        public bool SaveAll()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
