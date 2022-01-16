using Microsoft.EntityFrameworkCore;
using LabApi.Models;

namespace OrderMvc.Models
{
    public class FakeContext : DbContext
    {
        public FakeContext(DbContextOptions<FakeContext> options)
            : base(options)
        {
        }

        public DbSet<OrderItem> OrderItems{ get; set; }

        public DbSet<LabApi.Models.OrderItem> OrderItem { get; set; }
    }
}

    

