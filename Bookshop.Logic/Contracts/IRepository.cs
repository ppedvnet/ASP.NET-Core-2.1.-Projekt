using Bookshop.Models;
using System.Collections.Generic;

namespace Bookshop.Logic.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T FindById(int id);

        void Add(T entity);
        void Remove(T entity);

        bool SaveAll();
    }
}
