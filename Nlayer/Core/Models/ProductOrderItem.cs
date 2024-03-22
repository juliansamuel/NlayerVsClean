namespace Core.Models;

public class ProductOrderItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int OrderedQuantity { get; set; }
}