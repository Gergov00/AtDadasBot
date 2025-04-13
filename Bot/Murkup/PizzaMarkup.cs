using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Murkup;

public class PizzaMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Пицца",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей", "/pizza:aschicken"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с колбасой", "/pizza:assausage"), ],
                    [InlineKeyboardButton.WithCallbackData("Мясная", "/pizza:meat"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Маргорита\"", "/pizza:margorita"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Фирменая\"", "/pizza:firm"), ],
                    [InlineKeyboardButton.WithCallbackData("\"4 сыра\"", "/pizza:fourcheese"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Пепперони\"", "/pizza:pepperoni"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Цезарь\"", "/pizza:caesar"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu"), ],
                }
            )
        );
    }
    
    public static (string, InlineKeyboardMarkup) GetAsChikenMarkup()
    {
        return (
            "<b>«АССОРТИ» С КУРИЦЕЙ</b>\n<i>Состав: Соус красный, сыр, курица, помидоры, грибы</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, маленькая - 400р", "/addbasket:aschicken:400"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, средняя - 500р", "/addbasket:aschicken:500"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, большая - 600р", "/addbasket:aschicken:600"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
}