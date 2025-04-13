using Bot.Murkup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot.CommandHandler;

public class ShaurmaCommandHandler : ICommandHandler
{
    public string Command => "/shaurma";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        using var stream = System.IO.File.OpenRead("images/menuphoto.jpg");

        switch (update)
        {
            case CallbackQuery callbackQuery:

                var fileToSend = new InputFileStream(stream, "menuphoto.jpg");

                var (caption, inlineMarkup) = ShaurmaMarkup.GetMarkup();
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