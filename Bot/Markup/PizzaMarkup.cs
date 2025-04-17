using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Markup;

public static class PizzaMarkup
{
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetMarkup()
    {
        return (
            "Пицца",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей", "/pizza:aschicken"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с колбасой", "/pizza:assausage"), ],
                    [InlineKeyboardButton.WithCallbackData("Мясная", "/pizza:meat"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Маргарита\"", "/pizza:margarita"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Фирменная\"", "/pizza:firm"), ],
                    [InlineKeyboardButton.WithCallbackData("\"4 сыра\"", "/pizza:fourcheese"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Пепперони\"", "/pizza:pepperoni"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Цезарь\"", "/pizza:caesar"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/foodmenu"), ],
                }
            )
        );
    }
    
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetAsChikenMarkup()
    {
        return (
            "<b>«АССОРТИ» С КУРИЦЕЙ</b>\n<i>Состав: Соус красный, сыр, курица, помидоры, грибы</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, маль. - 400₽", "/addbasket:aschicken:400"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, сред. - 500₽", "/addbasket:aschicken:500"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с курицей, бол. - 660₽", "/addbasket:aschicken:660"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetAsSausageMarkup()
    {
        return (
            "<b>«АССОРТИ» С КОЛБАСОЙ</b>\n<i>Соус красный, сыр, колбаса, помидоры, грибы</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с колбасой, маль. - 400₽", "/addbasket:assausage:400"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с колбасой, сред. - 500₽", "/addbasket:assausage:500"), ],
                    [InlineKeyboardButton.WithCallbackData("\"Ассорти\" с колбасой, бол. - 660₽", "/addbasket:assausage:660"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetMeatMarkup()
    {
        return (
            "<b>МЯСНАЯ</b>\n<i>Соус красный, сыр, сервелат, ветчина индейки, говядина копченая, курица</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Мясная, маль. - 500₽", "/addbasket:meat:500"), ],
                    [InlineKeyboardButton.WithCallbackData("Мясная, сред. - 700₽", "/addbasket:meat:700"), ],
                    [InlineKeyboardButton.WithCallbackData("Мясная, бол. - 900₽", "/addbasket:meat:900"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetMargaritaMarkup()
    {
        return (
            "<b>«МАРГАРИТА»</b>\n<i>Соус красный, сыр</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Маргарита, маль. - 350₽", "/addbasket:margarita:350"), ],
                    [InlineKeyboardButton.WithCallbackData("Маргарита, сред. - 450₽", "/addbasket:margarita:450"), ],
                    [InlineKeyboardButton.WithCallbackData("Маргарита, бол. - 600₽", "/addbasket:margarita:600"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetFirmMarkup()
    {
        return (
            "<b>«ФИРМЕННАЯ»</b>\n<i>Соус красный, сыр, сервелат говяжий, перец болгарский, помидор, фри</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Фирменная, маль. - 500₽", "/addbasket:firm:500"), ],
                    [InlineKeyboardButton.WithCallbackData("Фирменная, сред. - 700₽", "/addbasket:firm:700"), ],
                    [InlineKeyboardButton.WithCallbackData("Фирменная, бол. - 900₽", "/addbasket:firm:900"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetFourCheeseMarkup()
    {
        return (
            "<b>«4 СЫРА»</b>\n<i>Соус белый фирменный, сыр: моцарелла, пармезан, фетакс, российский</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("4 сыра, маль. - 430₽", "/addbasket:fourcheese:400"), ],
                    [InlineKeyboardButton.WithCallbackData("4 сыра, сред. - 550₽", "/addbasket:fourcheese:500"), ],
                    [InlineKeyboardButton.WithCallbackData("4 сыра, бол. - 700₽", "/addbasket:fourcheese:650"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetPepperoniMarkup()
    {
        return (
            "<b>«ПЕППЕРОНИ»</b>\n<i>Соус красный, сыр, пепперони</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Пепперони, маль. - 400₽", "/addbasket:pepperoni:400"), ],
                    [InlineKeyboardButton.WithCallbackData("Пепперони, сред. - 500₽", "/addbasket:pepperoni:500"), ],
                    [InlineKeyboardButton.WithCallbackData("Пепперони, бол. - 700₽", "/addbasket:pepperoni:700"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }
    
    public static (string caption, InlineKeyboardMarkup inlineMarkup) GetCaesarMarkup()
    {
        return (
            "<b>«ЦЕЗАРЬ»</b>\n<i>Соус белый фирменный, сыр, курица, помидоры, лист салата, яйцо перепелиное</i>\n\nНажмите чтобы добавить в корзину.",
            new InlineKeyboardMarkup(
                new InlineKeyboardButton[][]
                {
                    [InlineKeyboardButton.WithCallbackData("Цезарь, маль. - 450₽", "/addbasket:caesar:450"), ],
                    [InlineKeyboardButton.WithCallbackData("Цезарь, сред. - 600₽", "/addbasket:caesar:600"), ],
                    [InlineKeyboardButton.WithCallbackData("Цезарь, бол. - 750₽", "/addbasket:caesar:750"), ],
                    [InlineKeyboardButton.WithCallbackData("Назад", "/pizza"), ],
                }
            )
        );
    }

}