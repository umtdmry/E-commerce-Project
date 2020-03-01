using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.EFCore
{
    public class EFCoreCategoryRepository : ICategoryRepository
    {
        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetOne(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category category, int id)
        {
            throw new NotImplementedException();
        }
    }
}