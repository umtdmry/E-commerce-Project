using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetById(int id);
        TEntity GetOne(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);

        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}