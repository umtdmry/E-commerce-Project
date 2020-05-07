using System.Collections.Generic;
using E_commerce.Entity;

namespace E_commerce.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);

    }
}