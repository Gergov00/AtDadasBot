using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;


namespace Bot.Murkup;

public class MenuMarkup
{
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetMarkup()
    {
        return
        (
            "Главное меню",
            new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Меню блюд", "/foodmenu")],
                    [InlineKeyboardButton.WithCallbackData("Корзина", "/basket")]
                }
            )
        );
    }
}