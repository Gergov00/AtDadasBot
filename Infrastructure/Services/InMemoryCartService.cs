using System.Collections.Concurrent;
using Domain.Models;

namespace Infrastructure.Services;

public class InMemoryCartService : ICartService
{
    private readonly ConcurrentDictionary<long, List<CartItem>> _carts 
        = new();

    public void AddItem(long userId, CartItem item)
    {
        var cart = _carts.GetOrAdd(userId, _ => new List<CartItem>());
        var existing = cart.FirstOrDefault(x => x.ProductKey == item.ProductKey);
        if (existing != null)
            existing.Quantity += item.Quantity;
        else
            cart.Add(item);
    }

    public void RemoveItem(long userId, string productKey)
    {
        if (_carts.TryGetValue(userId, out var cart))
            cart.RemoveAll(x => x.ProductKey == productKey);
    }

    public void ClearCart(long userId)
    {
        _carts.TryRemove(userId, out _);
    }

    public List<CartItem> GetCart(long userId)
        => _carts.TryGetValue(userId, out var cart) 
            ? cart 
            : new List<CartItem>();
}
