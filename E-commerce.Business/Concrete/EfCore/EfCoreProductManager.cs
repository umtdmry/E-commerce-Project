using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using E_commerce.Business.Abstract;
using E_commerce.Entity;

namespace E_commerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public void Create(Product entity)
        {
            _productRepository.Create(entity);        
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }
    }
}