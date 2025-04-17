using Bot.Markup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.CommandHandler;

public class CartCommandHandler : ICommandHandler
{
    private readonly ICartService _cart;

    public CartCommandHandler(ICartService cartService)
    {
        _cart = cartService;
    }

    public string Command => "/cart";

    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        if (update is not CallbackQuery cq)
            throw new ArgumentException();

        var userId = cq.From.Id;
        (string text, InlineKeyboardMarkup markup) view;

        if (args?.StartsWith(":remove:") == true)
        {
            var key = args.Split(':')[2];
            _cart.RemoveItem(userId, key);
            view = CartMarkup.GetCartView(_cart.GetCart(userId));
        }
        else if (args == ":clear")
        {
            _cart.ClearCart(userId);
            view = CartMarkup.GetCartView(_cart.GetCart(userId));
        }
        else if (args == ":checkout")
        {
            view = ("Спасибо! Ваш заказ принят в обработку. Мы скоро свяжемся с вами.",
                new InlineKeyboardMarkup( InlineKeyboardButton.WithCallbackData("🔙 В начало", "/foodmenu") ));
        }
        else
        {
            view = CartMarkup.GetCartView(_cart.GetCart(userId));
        }

        using var stream = System.IO.File.OpenRead("images/logo.jpg");
        
        var fileToSend = new InputFileStream(stream, "logo.jpg");

        var (caption, inlineMarkup) = view;
        
        var media = new InputMediaPhoto(fileToSend)
        {
            Caption = caption,
            ParseMode = ParseMode.Html
        };
        
        await bot.EditMessageMedia(
            cq.Message.Chat.Id,
            cq.Message.MessageId,
            media: media,
            replyMarkup: inlineMarkup
        );
    }
}
