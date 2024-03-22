using Application.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ShopDbContext _ctx;

    public ProductRepository(ShopDbContext ctx)
    {
        _ctx = ctx;
    }
    public async Task DecreaseProductsQuantity(List<ProductOrderItem> orderedProducts)
    {
        foreach (var item in orderedProducts)
        {
            var product = await _ctx.Products.FirstOrDefaultAsync(p => p.Id == item.Product.Id);
            if (product != null)
            {
                product.DecreaseQuantityOnHand(item.OrderedQuantity);
                _ctx.Products.Update(product);
            }
        }
    }
}