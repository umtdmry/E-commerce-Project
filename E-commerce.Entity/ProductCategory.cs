using System.Reflection.Emit;

namespace E_commerce.Entity
{
    public class ProductCategory
    {
        //Junked table entity with product and category.
        
        //Primary Key = productId and categoryId
        //Because the product id and category cannot be found in the same combination. We can use two PK.
        
        private int _productId;
        private Product _product;
        
        private int _categoryId;
        private Category _category;

        public int productId
        {
            get => _productId;
            set => _productId = value;
        }
        public Product product            
        {                                 
            get => _product;              
            set => _product = value;      
        }                                 

        public int categoryId
        {
            get => _categoryId;
            set => _categoryId = value;
        }

        public Category category       
        {                              
            get => _category;          
            set => _category = value;  
        }                              
    }
}