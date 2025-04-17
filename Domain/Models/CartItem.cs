namespace Domain.Models;

public class CartItem
{
    public string ProductKey { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}