using Domain.Models;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup;

public static class CartMarkup
{
    public static (string, InlineKeyboardMarkup) GetCartView(List<CartItem> items)
    {
        if (items.Count == 0)
            return ("Ваша корзина пуста 😔", new InlineKeyboardMarkup(
                InlineKeyboardButton.WithCallbackData("🔙 Назад", "/foodmenu")
            ));

        var rows = new List<InlineKeyboardButton[]>();
        foreach (var it in items)
        {
            rows.Add(new[]
            {
                InlineKeyboardButton.WithCallbackData(
                    $"{it.Title} x{it.Quantity} — {it.Price*it.Quantity} ₽",
                    $"/cart:remove:{it.ProductKey}"
                )
            });
        }

        var total = items.Sum(x => x.Price * x.Quantity);
        rows.Add(new[] { InlineKeyboardButton.WithCallbackData($"Итого: {total} ₽", "ignore") });

        rows.Add(new[]
        {
            InlineKeyboardButton.WithCallbackData("🗑 Очистить", "/cart:clear"),
            InlineKeyboardButton.WithCallbackData("✅ Оформить", "/cart:checkout")
        });
        rows.Add(new[] { InlineKeyboardButton.WithCallbackData("🔙 Назад", "/foodmenu") });

        var markup = new InlineKeyboardMarkup(rows);
        return ($"<b>Ваша корзина</b>\n\n", markup);
    }
}
