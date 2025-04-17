using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup
{
    public static class DrinksMarkup
    {
        // Главное меню напитков
        public static (string, InlineKeyboardMarkup) GetMarkup() =>
            (
                "🍹 <b>Напитки</b> 🍹",
                new InlineKeyboardMarkup(new[]
                {
                    new[] { InlineKeyboardButton.WithCallbackData("☕ Кофе",     "/drinks:coffee") },
                    new[] { InlineKeyboardButton.WithCallbackData("🥤 Газировки","/drinks:soda")   },
                    new[] { InlineKeyboardButton.WithCallbackData("💧 Вода",     "/drinks:water")  },
                    new[] { InlineKeyboardButton.WithCallbackData("🔙 Назад",    "/foodmenu")      },
                })
            );

        // Кофе: 200мл/400мл, каждая кнопка — своя строка
        public static (string, InlineKeyboardMarkup) GetCoffeeMarkup() =>
            (
                "<b>Кофе</b>\n\nВыберите объём и сразу добавьте в корзину:",
                new InlineKeyboardMarkup(new[]
                {
                    new[] { InlineKeyboardButton.WithCallbackData("Американо 200 мл — 105 ₽",  "/addbasket:americano:105") },
                    new[] { InlineKeyboardButton.WithCallbackData("Американо 400 мл — 210 ₽",  "/addbasket:americano:210") },
                    new[] { InlineKeyboardButton.WithCallbackData("Капучино 200 мл — 120 ₽",   "/addbasket:capuchino:120") },
                    new[] { InlineKeyboardButton.WithCallbackData("Капучино 400 мл — 240 ₽",   "/addbasket:capuchino:240") },
                    new[] { InlineKeyboardButton.WithCallbackData("Латте 200 мл — 140 ₽",       "/addbasket:latte:140")     },
                    new[] { InlineKeyboardButton.WithCallbackData("Латте 400 мл — 280 ₽",       "/addbasket:latte:280")     },
                    new[] { InlineKeyboardButton.WithCallbackData("Флэт Вайт 200 мл — 140 ₽",   "/addbasket:flatwhite:140") },
                    new[] { InlineKeyboardButton.WithCallbackData("Флэт Вайт 400 мл — 280 ₽",   "/addbasket:flatwhite:280") },
                    new[] { InlineKeyboardButton.WithCallbackData("Эспрессо — 80 ₽",           "/addbasket:espresso:80")   },
                    new[] { InlineKeyboardButton.WithCallbackData("Двойной эспрессо — 100 ₽","/addbasket:despresso:100")},
                    new[] { InlineKeyboardButton.WithCallbackData("Раф — 160 ₽",               "/addbasket:raf:160")       },
                    new[] { InlineKeyboardButton.WithCallbackData("Какао — 120 ₽",             "/addbasket:cacao:120")     },
                    new[] { InlineKeyboardButton.WithCallbackData("🔙 Назад",                   "/drinks")                  },
                })
            );

        // Газировки: по одной кнопке на строку
        public static (string, InlineKeyboardMarkup) GetSodaMarkup() =>
            (
                "<b>Газировки</b>\n\nВыберите объём и сразу добавьте в корзину:",
                new InlineKeyboardMarkup(new[]
                {
                    new[] { InlineKeyboardButton.WithCallbackData("Кола 0.5 л — 85 ₽",  "/addbasket:cola05:85") },
                    new[] { InlineKeyboardButton.WithCallbackData("Кола 1 л — 120 ₽",   "/addbasket:cola1:120") },
                    new[] { InlineKeyboardButton.WithCallbackData("Фанта — 85 ₽",        "/addbasket:fanta:85")   },
                    new[] { InlineKeyboardButton.WithCallbackData("Спрайт — 85 ₽",       "/addbasket:sprite:85")  },
                    new[] { InlineKeyboardButton.WithCallbackData("Натахтари — 110 ₽",   "/addbasket:natah:110")  },
                    new[] { InlineKeyboardButton.WithCallbackData("🔙 Назад",             "/drinks")               },
                })
            );

        // Вода: по одной кнопке на строку
        public static (string, InlineKeyboardMarkup) GetWaterMarkup() =>
            (
                "<b>Вода</b>\n\nДобавьте в корзину одним нажатием:",
                new InlineKeyboardMarkup(new[]
                {
                    new[] { InlineKeyboardButton.WithCallbackData("Питьевая — 40 ₽",    "/addbasket:watercommon:40") },
                    new[] { InlineKeyboardButton.WithCallbackData("Минеральная — 60 ₽",  "/addbasket:watermin:60")    },
                    new[] { InlineKeyboardButton.WithCallbackData("Газированная — 60 ₽", "/addbasket:watergas:60")    },
                    new[] { InlineKeyboardButton.WithCallbackData("🔙 Назад",              "/drinks")                 },
                })
            );
    }
}
