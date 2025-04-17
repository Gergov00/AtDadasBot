using Bot.Markup;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.CommandHandler;

public class ShaurmaCommandHandler : ICommandHandler
{
    public string Command => "/shaurma";

    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        if (update is not CallbackQuery cq)
            throw new ArgumentException("Unsupported update type", nameof(update));

        (string caption, InlineKeyboardMarkup markup, string imagePath) = args switch
        {
            ":shaurma"        => (ShaurmaMarkup.GetShaurma().Item1, ShaurmaMarkup.GetShaurma().Item2, "images/defaut.jpg"),
            ":giroinlavash"   => (ShaurmaMarkup.GetGiroInLavash().Item1, ShaurmaMarkup.GetGiroInLavash().Item2, "images/Shaurma/giro_lavash.jpg"),
            ":giroinlepeshka" => (ShaurmaMarkup.GetGiroInLepeshka().Item1, ShaurmaMarkup.GetGiroInLepeshka().Item2, "images/Shaurma/giro_lepeshka.jpg"),
            ":pita"           => (ShaurmaMarkup.GetPita().Item1, ShaurmaMarkup.GetPita().Item2, "images/Shaurma/pita_plate.jpg"),
            ":dathotdog"      => (ShaurmaMarkup.GetDanishHotDog().Item1, ShaurmaMarkup.GetDanishHotDog().Item2, "images/danish_hotdog.jpg"),
            ":franhotdog"     => (ShaurmaMarkup.GetFrenchHotDog().Item1, ShaurmaMarkup.GetFrenchHotDog().Item2, "images/french_hotdog.jpg"),
            _                 => (ShaurmaMarkup.GetMarkup().Item1, ShaurmaMarkup.GetMarkup().Item2, "images/logo.jpg")
        };

        using var stream = File.OpenRead(imagePath);
        var file = new InputFileStream(stream, Path.GetFileName(imagePath));
        var media = new InputMediaPhoto(file)
        {
            Caption = caption,
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

