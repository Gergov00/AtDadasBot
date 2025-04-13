using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Murkup;

public class OtherMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Прочее",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Картошка фри", "/other:free")],
                    [InlineKeyboardButton.WithCallbackData("Наггетсы", "/other:nagets")],
                    [InlineKeyboardButton.WithCallbackData("Острые крылья", "/other:chicken")],
                    [InlineKeyboardButton.WithCallbackData("Пончики", "/other:donat")],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu")],
                }
            )
        );
    }
}