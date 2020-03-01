using System;
using System.Linq;
using System.Linq.Expressions;
using E_commerce.Entity;

namespace DataAccess.Abstract
{
    public interface IProductRepository
    {
        Product GetById(int id);
        Product GetOne(Expression<Func<Product, bool>> filter);
        IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter);

        void Create(Product product);
        void Delete(int id);
        void Edit(Product product, int id);
        

    }
}