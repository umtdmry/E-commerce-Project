using System.Collections.Generic;
using E_commerce.Entity;

namespace E_commerce.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

    }
}