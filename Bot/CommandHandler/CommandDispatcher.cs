using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bot.CommandHandler;

public class CommandDispatcher
{
    private readonly Dictionary<string, ICommandHandler> _handlers;

    public CommandDispatcher(IEnumerable<ICommandHandler> handlers)
    {
        _handlers = handlers.ToDictionary(h => h.Command, h => h, StringComparer.OrdinalIgnoreCase);
    }

    public async Task DispatchAsync(string command, TelegramBotClient bot, object? update, string args)
    {
        if (_handlers.TryGetValue(command, out var handler))
            await handler.HandleAsync(args, bot, update);
        else
            Console.WriteLine($"Не зарегестрированая команда {command}");
    }

  
}