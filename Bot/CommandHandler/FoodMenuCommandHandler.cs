using Bot.Murkup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Bot.CommandHandler;

public class FoodMenuCommandHandler : ICommandHandler
{
    public string Command => "/foodmenu";

    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        using var stream = System.IO.File.OpenRead("images/menuphoto.png");

        var fileToSend = new InputFileStream(stream, "menuphoto.png");

        var (caption, inlineMarkup) = FoodMenuMarkup.GetMarkup();
        switch (update)
        {
            case CallbackQuery callbackQuery:

                var media = new InputMediaPhoto(fileToSend)
                {
                    Caption = caption,
                    ParseMode = ParseMode.None
                };
                await bot.EditMessageMedia(
                    callbackQuery.Message.Chat.Id,
                    callbackQuery.Message.MessageId,
                    media: media,
                    inlineMarkup
                );
                break;
            default:
                throw new ArgumentException("Unsupported update type", nameof(update));
        }
    }
}