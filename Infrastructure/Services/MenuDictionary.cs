using Domain.Models;

namespace Infrastructure.Services;

public static class MenuDictionary
    {
        public static readonly Dictionary<string, CartItem> Items = new Dictionary<string, CartItem>
        {
            // --- PIZZA ---
            [":aschicken:400"]   = new CartItem { ProductKey = "aschicken",  Title = "Ассорти с курицей, маленькая",     Price = 400, Quantity = 1 },
            [":aschicken:500"]   = new CartItem { ProductKey = "aschicken",  Title = "Ассорти с курицей, средняя",       Price = 500, Quantity = 1 },
            [":aschicken:660"]   = new CartItem { ProductKey = "aschicken",  Title = "Ассорти с курицей, большая",       Price = 660, Quantity = 1 },

            [":assausage:400"]   = new CartItem { ProductKey = "assausage",  Title = "Ассорти с колбасой, маленькая",     Price = 400, Quantity = 1 },
            [":assausage:500"]   = new CartItem { ProductKey = "assausage",  Title = "Ассорти с колбасой, средняя",       Price = 500, Quantity = 1 },
            [":assausage:660"]   = new CartItem { ProductKey = "assausage",  Title = "Ассорти с колбасой, большая",       Price = 660, Quantity = 1 },

            [":meat:500"]        = new CartItem { ProductKey = "meat",       Title = "Мясная, маленькая",                 Price = 500, Quantity = 1 },
            [":meat:700"]        = new CartItem { ProductKey = "meat",       Title = "Мясная, средняя",                   Price = 700, Quantity = 1 },
            [":meat:900"]        = new CartItem { ProductKey = "meat",       Title = "Мясная, большая",                   Price = 900, Quantity = 1 },

            [":margarita:350"]   = new CartItem { ProductKey = "margarita",  Title = "Маргарита, маленькая",              Price = 350, Quantity = 1 },
            [":margarita:450"]   = new CartItem { ProductKey = "margarita",  Title = "Маргарита, средняя",                Price = 450, Quantity = 1 },
            [":margarita:600"]   = new CartItem { ProductKey = "margarita",  Title = "Маргарита, большая",                Price = 600, Quantity = 1 },

            [":firm:500"]        = new CartItem { ProductKey = "firm",       Title = "Фирменная, маленькая",              Price = 500, Quantity = 1 },
            [":firm:700"]        = new CartItem { ProductKey = "firm",       Title = "Фирменная, средняя",                Price = 700, Quantity = 1 },
            [":firm:900"]        = new CartItem { ProductKey = "firm",       Title = "Фирменная, большая",                Price = 900, Quantity = 1 },

            [":fourcheese:400"]  = new CartItem { ProductKey = "fourcheese", Title = "4 сыра, маленькая",                 Price = 400, Quantity = 1 },
            [":fourcheese:500"]  = new CartItem { ProductKey = "fourcheese", Title = "4 сыра, средняя",                   Price = 500, Quantity = 1 },
            [":fourcheese:650"]  = new CartItem { ProductKey = "fourcheese", Title = "4 сыра, большая",                   Price = 650, Quantity = 1 },

            [":pepperoni:400"]   = new CartItem { ProductKey = "pepperoni",  Title = "Пепперони, маленькая",               Price = 400, Quantity = 1 },
            [":pepperoni:500"]   = new CartItem { ProductKey = "pepperoni",  Title = "Пепперони, средняя",                 Price = 500, Quantity = 1 },
            [":pepperoni:700"]   = new CartItem { ProductKey = "pepperoni",  Title = "Пепперони, большая",                 Price = 700, Quantity = 1 },

            [":caesar:450"]      = new CartItem { ProductKey = "caesar",     Title = "Цезарь, маленькая",                  Price = 450, Quantity = 1 },
            [":caesar:600"]      = new CartItem { ProductKey = "caesar",     Title = "Цезарь, средняя",                    Price = 600, Quantity = 1 },
            [":caesar:750"]      = new CartItem { ProductKey = "caesar",     Title = "Цезарь, большая",                    Price = 750, Quantity = 1 },

            // --- SHAURMA & CO ---
            [":shaurma:250"]         = new CartItem { ProductKey = "shaurma",        Title = "Шаурма",                Price = 250, Quantity = 1 },
            [":giroinlavash:280"]    = new CartItem { ProductKey = "giroinlavash",   Title = "Гиро в лаваше",         Price = 280, Quantity = 1 },
            [":giroinlepeshka:280"]  = new CartItem { ProductKey = "giroinlepeshka", Title = "Гиро в лепешке",        Price = 280, Quantity = 1 },
            [":pita:380"]            = new CartItem { ProductKey = "pita",            Title = "Пита в тарелке",        Price = 380, Quantity = 1 },
            [":dathotdog:180"]       = new CartItem { ProductKey = "dathotdog",       Title = "Датский хот‑дог",       Price = 180, Quantity = 1 },
            [":franhotdog:150"]      = new CartItem { ProductKey = "franhotdog",      Title = "Французский хот‑дог",   Price = 150, Quantity = 1 },

            // --- OTHER ---
            [":free:120"]        = new CartItem { ProductKey = "free",        Title = "Картошка фри (100 г)",     Price = 120, Quantity = 1 },
            [":nagets:140"]      = new CartItem { ProductKey = "nagets",      Title = "Наггетсы (6 шт.)",         Price = 140, Quantity = 1 },
            [":chicken:280"]     = new CartItem { ProductKey = "chicken",     Title = "Крылья острые (5 шт.)",    Price = 280, Quantity = 1 },
            [":donat:120"]       = new CartItem { ProductKey = "donat",       Title = "Пончики (1 шт.)",          Price = 120, Quantity = 1 },

            // --- DRINKS: Coffee ---
            [":americano:105"]   = new CartItem { ProductKey = "americano",   Title = "Американо 200 мл",      Price = 105, Quantity = 1 },
            [":americano:210"]   = new CartItem { ProductKey = "americano",   Title = "Американо 400 мл",      Price = 210, Quantity = 1 },
            [":capuchino:120"]   = new CartItem { ProductKey = "capuchino",   Title = "Капучино 200 мл",       Price = 120, Quantity = 1 },
            [":capuchino:240"]   = new CartItem { ProductKey = "capuchino",   Title = "Капучино 400 мл",       Price = 240, Quantity = 1 },
            [":latte:140"]       = new CartItem { ProductKey = "latte",       Title = "Латте 200 мл",          Price = 140, Quantity = 1 },
            [":latte:280"]       = new CartItem { ProductKey = "latte",       Title = "Латте 400 мл",          Price = 280, Quantity = 1 },
            [":flatwhite:140"]   = new CartItem { ProductKey = "flatwhite",   Title = "Флэт Вайт 200 мл",      Price = 140, Quantity = 1 },
            [":flatwhite:280"]   = new CartItem { ProductKey = "flatwhite",   Title = "Флэт Вайт 400 мл",      Price = 280, Quantity = 1 },
            [":espresso:80"]     = new CartItem { ProductKey = "espresso",    Title = "Эспрессо",              Price = 80,  Quantity = 1 },
            [":despresso:100"]   = new CartItem { ProductKey = "despresso",   Title = "Двойной эспрессо",      Price = 100, Quantity = 1 },
            [":raf:160"]         = new CartItem { ProductKey = "raf",         Title = "Раф",                   Price = 160, Quantity = 1 },
            [":cacao:120"]       = new CartItem { ProductKey = "cacao",       Title = "Какао",                 Price = 120, Quantity = 1 },

            // --- DRINKS: Soda ---
            [":cola05:85"]       = new CartItem { ProductKey = "cola05",      Title = "Кола 0.5 л",            Price = 85,  Quantity = 1 },
            [":cola1:120"]       = new CartItem { ProductKey = "cola1",       Title = "Кола 1 л",              Price = 120, Quantity = 1 },
            [":fanta:85"]        = new CartItem { ProductKey = "fanta",       Title = "Фанта",                 Price = 85,  Quantity = 1 },
            [":sprite:85"]       = new CartItem { ProductKey = "sprite",      Title = "Спрайт",                Price = 85,  Quantity = 1 },
            [":natah:110"]       = new CartItem { ProductKey = "natah",       Title = "Натахтари",             Price = 110, Quantity = 1 },

            // --- DRINKS: Water ---
            [":watercommon:40"]  = new CartItem { ProductKey = "watercommon", Title = "Вода питьевая",         Price = 40,  Quantity = 1 },
            [":watermin:60"]     = new CartItem { ProductKey = "watermin",    Title = "Вода минеральная",      Price = 60,  Quantity = 1 },
            [":watergas:60"]     = new CartItem { ProductKey = "watergas",    Title = "Вода газированная",     Price = 60,  Quantity = 1 },
        };
    }