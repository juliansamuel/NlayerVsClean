namespace Domain.Models;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public int QuantityOnHand { get; set; }

    public void DecreaseQuantityOnHand(int byValue)
    {
        QuantityOnHand -= byValue;
    }
}