using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup;

public static class ShaurmaMarkup
{
    public static (string, InlineKeyboardMarkup) GetMarkup()
    {
        return (
            "Шаурма, Гиро и Хот‑доги",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Шаурма", "/shaurma:shaurma") },
                new[] { InlineKeyboardButton.WithCallbackData("Гиро в лаваше", "/shaurma:giroinlavash") },
                new[] { InlineKeyboardButton.WithCallbackData("Гиро в лепешке", "/shaurma:giroinlepeshka") },
                new[] { InlineKeyboardButton.WithCallbackData("Пита в тарелке", "/shaurma:pita") },
                new[] { InlineKeyboardButton.WithCallbackData("Датский хот‑дог", "/shaurma:dathotdog") },
                new[] { InlineKeyboardButton.WithCallbackData("Французский хот‑дог", "/shaurma:franhotdog") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetShaurma()
    {
        return (
            "<b>ШАУРМА</b>\n<i>Лаваш, соус белый фирменный, капуста, помидоры, огурцы, курица, горчица</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Шаурма — 250₽", "/addbasket:shaurma:250") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetGiroInLavash()
    {
        return (
            "<b>ГИРО В ЛАВАШЕ</b>\n<i>Лаваш, соус белый фирменный, курица, капуста, картофель фри, томаты</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Гиро в лаваше — 280₽", "/addbasket:giroinlavash:280") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetGiroInLepeshka()
    {
        return (
            "<b>ГИРО В ЛЕПЕШКЕ</b>\n<i>Лепешка, соус белый фирменный, курица, капуста, картофель фри, томаты</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Гиро в лепешке — 280₽", "/addbasket:giroinlepeshka:280")
                },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetPita()
    {
        return (
            "<b>ПИТА В ТАРЕЛКЕ</b>\n<i>Курица, соус белый фирменный, греческий салат, картофель фри, лепёшка</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Пита в тарелке — 380₽", "/addbasket:pita:380") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetDanishHotDog()
    {
        return (
            "<b>ДАТСКИЙ ХОТ‑ДОГ</b>\n<i>Булка датская, сосиска, лист салата, помидоры, огурцы, горчица</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("Датский хот‑дог — 180₽", "/addbasket:dathotdog:180") },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }

    public static (string, InlineKeyboardMarkup) GetFrenchHotDog()
    {
        return (
            "<b>ФРАНЦУЗСКИЙ ХОТ‑ДОГ</b>\n<i>Багет, сосиска, соус кетчуп, горчица</i>\n\nНажмите, чтобы добавить в корзину.",
            new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("Французский хот‑дог — 150₽", "/addbasket:franhotdog:150")
                },
                new[] { InlineKeyboardButton.WithCallbackData("Назад", "/shaurma") },
            })
        );
    }
}