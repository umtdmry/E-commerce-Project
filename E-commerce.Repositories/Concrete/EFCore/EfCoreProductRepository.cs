using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.EFCore
{
    public class EfCoreProductRepository : EfCoreBaseRepository<Product, ShopContext>, IProductRepository
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}