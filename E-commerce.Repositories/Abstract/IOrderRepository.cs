using System;
using System.Linq;
using System.Linq.Expressions;
using E_commerce.Entity;

namespace DataAccess.Abstract
{
    public interface IOrderRepository :IBaseRepository<Order>
    {
    }
}