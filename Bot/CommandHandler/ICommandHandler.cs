using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bot.CommandHandler;

public interface ICommandHandler
{
    string Command { get; }

    Task HandleAsync(string? args, TelegramBotClient bot, object? update);


}