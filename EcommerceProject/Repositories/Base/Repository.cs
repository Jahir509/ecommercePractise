using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseContext.DbContext;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.Base
{
    public abstract class Repository<T>:IRepository<T> where T:class            // MAIKING A Generic CLASS Using T
                                                                 // Thats Why it Could not be possible to make this class
    {
        protected EcommerceDatabaseContext db;

        public Repository()
        {
            db = new EcommerceDatabaseContext();
        }

        private DbSet<T> Table
        {
            get { return db.Set<T>(); }
        }
        public virtual bool Add(T entity)
        {
            Table.Add(entity);
            return db.SaveChanges() > 0;
        }

        public virtual bool Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public virtual bool Remove(T entity)
        {
            Table.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return Table.ToList();
        }
    }
}
