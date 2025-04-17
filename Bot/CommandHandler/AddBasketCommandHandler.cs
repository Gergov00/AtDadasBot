using Infrastructure.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bot.CommandHandler;

public class AddBasketCommandHandler : ICommandHandler
{

    private readonly ICartService _cartService;

    public AddBasketCommandHandler(ICartService cartService)
    {
        _cartService = cartService;
    }
    
    public string Command => "/addbasket";
    public async Task HandleAsync(string? args, TelegramBotClient bot, object? update)
    {
        
        if (update is not CallbackQuery cq)
            throw new ArgumentException("Unsupported update type", nameof(update));
        if (MenuDictionary.Items.TryGetValue(args, out var item))
        {
            _cartService.AddItem(cq.From.Id, item);
            await bot.AnswerCallbackQueryAsync(cq.Id, $"Добавлено: {item.Title}");
        }
        else
        {
            throw new ArgumentException("Неправильный аргумент");
        }
    }
}