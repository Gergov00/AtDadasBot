using Bot.Markup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.CommandHandler;

public class OtherCommandHandler : ICommandHandler
{
    public string Command => "/others";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        if (update is not CallbackQuery cq)
            throw new ArgumentException("Unsupported update type", nameof(update));

        (string caption, InlineKeyboardMarkup markup, string imagePath) = args switch
        {
            ":free"    => (OtherMarkup.GetFriesMarkup().Item1,       OtherMarkup.GetFriesMarkup().Item2,       "images/Others/fries.jpg"),
            ":nagets"  => (OtherMarkup.GetNuggetsMarkup().Item1,     OtherMarkup.GetNuggetsMarkup().Item2,     "images/Others/nuggets.jpg"),
            ":chicken" => (OtherMarkup.GetSpicyWingsMarkup().Item1,  OtherMarkup.GetSpicyWingsMarkup().Item2,  "images/defaut.jpg"),
            ":donat"   => (OtherMarkup.GetDonutsMarkup().Item1,      OtherMarkup.GetDonutsMarkup().Item2,      "images/Others/donuts.jpg"),
            _          => (OtherMarkup.GetMarkup().Item1,            OtherMarkup.GetMarkup().Item2,            "images/logo.jpg"),
        };

        using var stream = File.OpenRead(imagePath);
        var file = new InputFileStream(stream, Path.GetFileName(imagePath));

        var media = new InputMediaPhoto(file)
        {
            Caption   = caption,
            ParseMode = ParseMode.Html
        };

        await bot.EditMessageMedia(
            cq.Message.Chat.Id,
            cq.Message.MessageId,
            media,
            markup
        );
    }
}