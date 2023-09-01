using Microsoft.EntityFrameworkCore;

namespace ShıpmentFormAplicationInNetCore.Models
{
    public class OrderShipmentContext : DbContext
    {
        public OrderShipmentContext(DbContextOptions<OrderShipmentContext> options) : base(options)
        {
                
        }
     public   DbSet<OrderShipment> OrderShipment { get; set; }
     public   DbSet<Customer> Customer { get; set; }
     public   DbSet<Product> Product { get; set; }
    }
}
