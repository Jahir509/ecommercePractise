using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using BLL.Contracts;
using Repositories.Base;
using Repositories.Contracts;

namespace BLL.Base
{
    public abstract class Manager<T>:IManager<T> where T:class
    {
        private IRepository<T> _repository;

        public Manager(IRepository<T> repository)                    //Constructor with Parameter. Other class must inherit this also with parameter
        {
            _repository =  repository;
        }
        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }
        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }
        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
