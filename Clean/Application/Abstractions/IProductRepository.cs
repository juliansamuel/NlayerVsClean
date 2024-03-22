using Domain.Models;

namespace Application.Abstractions;

public interface IProductRepository
{
    Task DecreaseProductsQuantity(List<ProductOrderItem> orderedProducts);
}