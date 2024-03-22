using Core.Models;

namespace Core.Abstractions;

public interface IOrderRepository
{
    Task PlaceOrderAsync(Order order);
}