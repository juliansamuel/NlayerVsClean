using Core.Abstractions;
using Core.Models;

namespace DataAccess.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ShopDbContext _ctx;

    public OrderRepository(ShopDbContext ctx)
    {
        _ctx = ctx;
    }
    public Task PlaceOrderAsync(Order order)
    {
        order.OrderPlaced = DateTime.Now;
        _ctx.Orders.Update(order);
        return Task.CompletedTask;
    }
}