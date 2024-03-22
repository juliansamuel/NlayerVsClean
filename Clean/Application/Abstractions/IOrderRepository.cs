using Domain.Models;

namespace Application.Abstractions;

public interface IOrderRepository
{
    Task PlaceOrderAsync(Order order);
}