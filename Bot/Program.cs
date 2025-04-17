using Bot;
using Bot.CommandHandler;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Microsoft.Extensions.DependencyInjection;


var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();


var services = new ServiceCollection();

services.AddTransient<ICommandHandler, PizzaCommandHandler>();
services.AddTransient<ICommandHandler, OtherCommandHandler>();
services.AddTransient<ICommandHandler, DrinksCommnadHandler>();
services.AddTransient<ICommandHandler, ShaurmaCommandHandler>();
services.AddTransient<ICommandHandler, MenuCommandHandle>();
services.AddTransient<ICommandHandler, FoodMenuCommandHandler>();
services.AddTransient<ICommandHandler, AddBasketCommandHandler>();
services.AddTransient<ICommandHandler, CartCommandHandler>();
services.AddSingleton<CommandDispatcher>();
services.AddSingleton<ICartService, InMemoryCartService>();

var serviceProvider = services.BuildServiceProvider();

var dispatcher = serviceProvider.GetRequiredService<CommandDispatcher>();


var token = config["TelegramBot:Token"];

using var cts = new CancellationTokenSource();

var bot = new TelegramBotClient(token, cancellationToken: cts.Token);

var me = await bot.GetMe();


bot.OnError += OnError;
bot.OnMessage += OnMessage;
bot.OnUpdate += OnUpdate;




Console.WriteLine($"@{me.Username} is running... Press Escape to terminate");
while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
cts.Cancel();




async Task OnError(Exception exception, HandleErrorSource source)
{
    Console.WriteLine(exception);
    await Task.Delay(2000, cts.Token);
}

async Task OnMessage(Message msg, UpdateType type)
{
    if (msg.Text is not { } text)
        Console.WriteLine($"Received a message of type {msg.Type}");
    else if (text.StartsWith('/'))
    {
        var space = text.IndexOf(' ');
        if (space < 0) space = text.Length;
        var command = text[..space].ToLower();
        if (command.LastIndexOf('@') is > 0 and int at) // it's a targeted command
            if (command[(at + 1)..].Equals(me.Username, StringComparison.OrdinalIgnoreCase))
                command = command[..at];
            else
                return; 
        await OnCommand(command, text[space..].TrimStart(), msg);
    }
    else
        await OnTextMessage(msg);
}

async Task OnTextMessage(Message msg) 
{
    Console.WriteLine($"Received text '{msg.Text}' in {msg.Chat}");
    await OnCommand("/start", "", msg); 
}

async Task OnCommand(string command, string args, Message msg)
{
    Console.WriteLine($"Received command: {command} {args}");
    switch (command)
    {
        case "/start":
            await dispatcher.DispatchAsync("/menu", bot, msg, null);
            break;
        
    }
}

async Task OnUpdate(Update update)
{
    switch (update)
    {
        case { CallbackQuery: { } callbackQuery }: await OnCallbackQuery(callbackQuery); break;
        case { PollAnswer: { } pollAnswer }: await OnPollAnswer(pollAnswer); break;
        default: Console.WriteLine($"Received unhandled update {update.Type}"); break;
    };
}

async Task OnCallbackQuery(CallbackQuery callbackQuery)
{
    var command = Parce(callbackQuery.Data);
    var args = callbackQuery.Data[command.Length..];
    dispatcher.DispatchAsync(command, bot, callbackQuery, args);
}

async Task OnPollAnswer(PollAnswer pollAnswer)
{
    if (pollAnswer.User != null)
        await bot.SendMessage(pollAnswer.User.Id, $"You voted for option(s) id [{string.Join(',', pollAnswer.OptionIds)}]");
}


string Parce(string data)
{
    if (data.Contains(':'))
    {
        var index = data.IndexOf(':');
        return data[..index];
    }

    return data;
}