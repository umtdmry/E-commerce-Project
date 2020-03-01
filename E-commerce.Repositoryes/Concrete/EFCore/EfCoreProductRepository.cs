using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.EFCore
{
    public class EfCoreProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product product, int id)
        {
            throw new NotImplementedException();
        }
    }
}