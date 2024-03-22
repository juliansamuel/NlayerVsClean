using Core.Models;

namespace Core.Abstractions;

public interface IProductRepository
{
    Task DecreaseProductsQuantity(List<ProductOrderItem> orderedProducts);
}