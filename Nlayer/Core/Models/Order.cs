namespace Core.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderCreated { get; set; }
    public DateTime OrderPlaced { get; set; }
    public List<ProductOrderItem> OrderedProducts { get; set; } = new();
}