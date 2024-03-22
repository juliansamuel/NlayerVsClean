using Application.Abstractions;
using Domain.Models;

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
        order.PlaceOrder();
        _ctx.Orders.Update(order);
        return Task.CompletedTask;
    }
}