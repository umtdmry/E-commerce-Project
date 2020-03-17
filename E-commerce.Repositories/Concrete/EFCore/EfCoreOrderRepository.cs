using DataAccess.Abstract;
using E_commerce.Entity;

namespace DataAccess.Concrete.EFCore
{
    public class EfCoreOrderRepository:EfCoreBaseRepository<Order,ShopContext>,IOrderRepository
    {
        
    }
}