using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Murkup;

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
                    [InlineKeyboardButton.WithCallbackData("Напитки", "/drinks")],
                    [InlineKeyboardButton.WithCallbackData("Прочие", "/others")],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/menu")],
                }
            )
        );
    }
}