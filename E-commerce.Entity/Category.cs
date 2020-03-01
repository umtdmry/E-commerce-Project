using System.Collections.Generic;

namespace E_commerce.Entity
{
    public class Category
    {
        private int _id;
        private string _name;
        private List<ProductCategory> _productCategories;

        public List<ProductCategory> productCategories
        {
            get => _productCategories;
            set => _productCategories = value;
        }
        public int id
        {
            get => _id;
            set => _id = value;
        }

        public string name
        {
            get => _name;
            set => _name = value;
        }
    }
}