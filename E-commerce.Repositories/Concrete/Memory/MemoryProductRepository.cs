using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.Memory
{
    public class MemoryProductRepository:IProductRepository
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    id = 1,
                    name = "Samsung S6",
                    imageUrl = "1.jpg",
                    price = 1000
                },
                new Product()
                {
                    id = 2,
                    name = "Samsung S7",
                    imageUrl = "2.jpg",
                    price = 2000
                },
                new Product()
                {
                    id = 3,
                    name = "Samsung S86",
                    imageUrl = "3.jpg",
                    price = 3000
                },
            };
            return products;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}