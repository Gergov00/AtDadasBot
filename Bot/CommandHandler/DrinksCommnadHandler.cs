using Bot.Markup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.CommandHandler;

public class DrinksCommnadHandler : ICommandHandler
{
    public string Command => "/drinks";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        if (update is not CallbackQuery cq)
            throw new ArgumentException("Unsupported update type", nameof(update));
        
        (string caption, InlineKeyboardMarkup inlineMarkup) = args switch
        {
            ":coffee" => DrinksMarkup.GetCoffeeMarkup(),
            ":soda"   => DrinksMarkup.GetSodaMarkup(),
            ":water"  => DrinksMarkup.GetWaterMarkup(),
            _         => DrinksMarkup.GetMarkup(),
        };
        
        using var stream = System.IO.File.OpenRead("images/logo.jpg");
        var fileToSend = new InputFileStream(stream, "logo.jpg");

        
                var media = new InputMediaPhoto(fileToSend)
                {
                    Caption = caption,
                    ParseMode = ParseMode.Html
                };
                await bot.EditMessageMedia(
                    cq.Message.Chat.Id,
                    cq.Message.MessageId,
                    media: media,
                    inlineMarkup
                );
             
    }
}