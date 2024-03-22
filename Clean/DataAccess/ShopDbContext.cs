using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ShopDbContext : DbContext
{
    public ShopDbContext(DbContextOptions options) : base(options)
    {
            
    }
    
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}