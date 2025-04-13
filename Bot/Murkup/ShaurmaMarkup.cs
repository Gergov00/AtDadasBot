using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Murkup;

public class ShaurmaMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Шаурма, Гиро и Хот-доги",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Шаурма", "/shaurma"), ],
                    [InlineKeyboardButton.WithCallbackData("Гиро в лаваше", "/giroinlavash"), ],
                    [InlineKeyboardButton.WithCallbackData("Гиро в лепешке", "/giroinlepeshka"), ],
                    [InlineKeyboardButton.WithCallbackData("Пита в тарелке", "/pita"), ],
                    [InlineKeyboardButton.WithCallbackData("Датский хот-дог", "/dathotdog"), ],
                    [InlineKeyboardButton.WithCallbackData("Француский хотдог", "/franhotdog"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu"), ],
                }
            )
        );
    }
}