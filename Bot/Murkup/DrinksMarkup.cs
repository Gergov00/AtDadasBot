using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Murkup;

public class DrinksMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Напитки/Кофе",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [
                        InlineKeyboardButton.WithCallbackData("Американо", "/drinks:americano"),
                        InlineKeyboardButton.WithCallbackData("Капучино", "/drinks:capuchino")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Лате", "/drinks:late"),
                        InlineKeyboardButton.WithCallbackData("Флэт Вайт", "/drinks:wait")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Эспрессо", "/drinks:espresso"),
                        InlineKeyboardButton.WithCallbackData("Двойной эспрессо", "/drinks:despresso")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Раф", "/drinks:raf"),
                        InlineKeyboardButton.WithCallbackData("Какао", "/drinks:cacao")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Кола", "/drinks:cola"),
                        InlineKeyboardButton.WithCallbackData("Фанта", "/drinks:fanta")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Спарайт", "/drinks:sprait"),
                        InlineKeyboardButton.WithCallbackData("Натахтари", "/drinks:natah")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Вода питьевая", "/drinks:watercommon"),
                        InlineKeyboardButton.WithCallbackData("Вода минерал.", "/drinks:watermin")
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Вода газ.", "/drinks:watergas"),
                        InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu")
                    ],

                }
            )
        );
    }
}