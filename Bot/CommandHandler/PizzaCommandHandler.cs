using Bot.Murkup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot.CommandHandler;

public class PizzaCommandHandler : ICommandHandler
{
    public string Command => "/pizza";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        switch (args)
        {
            case ":aschicken":
                await AsChicken(bot, update);
                break;
            default:
                await MainMenu(bot, update);
                break;
        }
    }


    public async Task MainMenu(TelegramBotClient bot, object? update)
    {
        using var stream = System.IO.File.OpenRead("images/menuphoto.jpg");

        switch (update) 
        {
            case CallbackQuery callbackQuery:
                
                var fileToSend = new InputFileStream(stream, "menuphoto.jpg");
                        
                var (caption, inlineMarkup) = PizzaMarkup.GetMarkup();
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
                break;
            default:
                throw new ArgumentException("Unsupported update type", nameof(update));
        }
    }

    public async Task AsChicken(TelegramBotClient bot, object? update)
    {
        using var stream = System.IO.File.OpenRead("images/menuphoto.jpg");

        switch (update) 
        {
            case CallbackQuery callbackQuery:
                
                var fileToSend = new InputFileStream(stream, "menuphoto.jpg");
                        
                var (caption, inlineMarkup) = PizzaMarkup.GetAsChikenMarkup();
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
                break;
            default:
                throw new ArgumentException("Unsupported update type", nameof(update));
        }
    }
}