using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup;

public class OtherMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Прочее",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Картошка фри", "/others:free") },
                new[] { InlineKeyboardButton.WithCallbackData("Наггетсы", "/others:nagets") },
                new[] { InlineKeyboardButton.WithCallbackData("Острые крылья", "/others:chicken") },
                new[] { InlineKeyboardButton.WithCallbackData("Пончики", "/others:donat") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetFriesMarkup()
    {
        return (
            "<b>КАРТОШКА ФРИ (100 г)</b>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Картошка фри—120₽", "/addbasket:free:120") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/others") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetNuggetsMarkup()
    {
        return (
            "<b>НАГГЕТСЫ (6 шт.)</b>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Наггетсы—140₽", "/addbasket:nagets:140") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/others") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetSpicyWingsMarkup()
    {
        return (
            "<b>КРЫЛЬЯ ОСТРЫЕ (5 шт.)</b>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Крылья острые—280₽", "/addbasket:chicken:280") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/others") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetDonutsMarkup()
    {
        return (
            "<b>ПОНЧИКИ (1 шт.)</b>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Белый с розовыми полосками—120₽", "/addbasket:donat:120")
                },
                new[] { InlineKeyboardButton.WithCallbackData("Коричневый с ореами—120₽", "/addbasket:donat:120") },
                new[] { InlineKeyboardButton.WithCallbackData("Красный с присыпкой—120₽", "/addbasket:donat:120") },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Белый с какой-то крошкой —120₽", "/addbasket:donat:120")
                },
                new[] { InlineKeyboardButton.WithCallbackData("Коричневый со стружкой—120₽", "/addbasket:donat:120") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/others") },
            })
        );
    }
}