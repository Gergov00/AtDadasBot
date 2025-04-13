using Bot.Murkup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot.CommandHandler;

public class MenuCommandHandle : ICommandHandler
{
    public string Command => "/menu";

    public async Task HandleAsync(string? args, TelegramBotClient bot, object update)
    {
        using var stream = System.IO.File.OpenRead("images/menuphoto.jpg");
        
        var fileToSend = new InputFileStream(stream, "menuphoto.jpg");

        var (caption, inlineMarkup) = MenuMarkup.GetMarkup();
        
        switch (update)
        {
            case CallbackQuery callback:
                var media = new InputMediaPhoto(fileToSend)
                {
                    Caption = caption,
                    ParseMode = ParseMode.Html
                };
                await bot.EditMessageMedia(
                    callback.Message.Chat.Id,
                    callback.Message.MessageId,
                    media: media,
                    replyMarkup: inlineMarkup
                );
                break;
            case Message message:
                await bot.SendPhoto(
                    message.Chat.Id,
                    fileToSend,
                    caption: caption,
                    parseMode: ParseMode.Html,
                    replyMarkup: inlineMarkup
                );
                break;
            default:
                throw new ArgumentException("Unsupported update type", nameof(update));
        }
        
        
        
        
    }
}