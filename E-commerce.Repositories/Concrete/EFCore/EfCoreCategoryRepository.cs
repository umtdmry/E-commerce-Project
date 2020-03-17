using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.EFCore
{
    public class EfCoreCategoryRepository : EfCoreBaseRepository<Category, ShopContext>, ICategoryRepository
    {
    }
}