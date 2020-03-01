using System;
using System.Linq;
using System.Linq.Expressions;
using E_commerce.Entity;

namespace DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        Category GetOne(Expression<Func<Category, bool>> filter);
        IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter);

        void Create(Category category);
        void Delete(int id);
        void Edit(Category category, int id);
    }
}