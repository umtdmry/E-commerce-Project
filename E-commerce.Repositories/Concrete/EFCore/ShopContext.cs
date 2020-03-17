using E_commerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EFCore
{
    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("jdbc:jtds:sqlserver://./;instance=<pipe name>;namedPipe=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}