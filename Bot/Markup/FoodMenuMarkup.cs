using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup;

public class FoodMenuMarkup
{
    static public (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Меню блюд",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Пицца", "/pizza")],
                    [InlineKeyboardButton.WithCallbackData("Шаурма/Хот-дог", "/shaurma")],
                    [InlineKeyboardButton.WithCallbackData("Картошка, наггетсы и прочее", "/others")],
                    [InlineKeyboardButton.WithCallbackData("Напитки", "/drinks")],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/menu")],
                }
            )
        );
    }
}