using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Common
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
