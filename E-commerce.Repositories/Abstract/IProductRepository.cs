using System.Collections.Generic;
using E_commerce.Entity;

namespace DataAccess.Abstract
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}