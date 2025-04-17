using Bot.Markup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot.CommandHandler;

public class PizzaCommandHandler : ICommandHandler
{
    public string Command => "/pizza";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        if (update is not CallbackQuery callbackQuery)
            throw new ArgumentException("Unsupported update type", nameof(update));

      
        var (caption, inlineMarkup, imagePath) = args switch
        {
            ":aschicken"   => (PizzaMarkup.GetAsChikenMarkup().caption, PizzaMarkup.GetAsChikenMarkup().inlineMarkup, "images/Pizza/aschicken.jpg"),
            ":assausage"   => (PizzaMarkup.GetAsSausageMarkup().caption, PizzaMarkup.GetAsSausageMarkup().inlineMarkup, "images/Pizza/assausage.jpg"),
            ":meat"        => (PizzaMarkup.GetMeatMarkup().caption, PizzaMarkup.GetMeatMarkup().inlineMarkup, "images/defaut.jpg"),
            ":margarita"   => (PizzaMarkup.GetMargaritaMarkup().caption, PizzaMarkup.GetMargaritaMarkup().inlineMarkup, "images/Pizza/margarita.jpg"),
            ":firm"        => (PizzaMarkup.GetFirmMarkup().caption, PizzaMarkup.GetFirmMarkup().inlineMarkup, "images/Pizza/firm.jpg"),
            ":fourcheese"  => (PizzaMarkup.GetFourCheeseMarkup().caption, PizzaMarkup.GetFourCheeseMarkup().inlineMarkup, "images/Pizza/fourcheese.jpg"),
            ":pepperoni"   => (PizzaMarkup.GetPepperoniMarkup().caption, PizzaMarkup.GetPepperoniMarkup().inlineMarkup, "images/Pizza/pepperoni.jpg"),
            ":caesar"      => (PizzaMarkup.GetCaesarMarkup().caption, PizzaMarkup.GetCaesarMarkup().inlineMarkup, "images/Pizza/caesar.jpg"),
            _              => (PizzaMarkup.GetMarkup().caption, PizzaMarkup.GetMarkup().inlineMarkup, "images/logo.jpg"),
        };

        using var stream = System.IO.File.OpenRead(imagePath);
        var fileToSend = new InputFileStream(stream, Path.GetFileName(imagePath));

        var media = new InputMediaPhoto(fileToSend)
        {
            Caption = caption,
            ParseMode = ParseMode.Html
        };

        await bot.EditMessageMedia(
            callbackQuery.Message.Chat.Id,
            callbackQuery.Message.MessageId,
            media,
            inlineMarkup
        );
    }

    
}