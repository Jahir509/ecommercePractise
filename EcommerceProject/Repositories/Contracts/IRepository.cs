using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IRepository<T> where T:class
    {
        bool Add(T enitity);
        bool Update(T enitity);
        bool Remove(T enitity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
