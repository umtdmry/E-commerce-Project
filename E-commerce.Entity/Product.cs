using System.Collections.Generic;

namespace E_commerce.Entity
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _imageUrl;
        private decimal _price;
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

        public string imageUrl
        {
            get => _imageUrl;
            set => _imageUrl = value;
        }

        public decimal price
        {
            get => _price;
            set => _price = value;
        }
    }
}