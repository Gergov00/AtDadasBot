using Domain.Models;

public interface ICartService
{
    void   AddItem(long userId, CartItem item);
    void   RemoveItem(long userId, string productKey);
    void   ClearCart(long userId);
    List<CartItem> GetCart(long userId);
}