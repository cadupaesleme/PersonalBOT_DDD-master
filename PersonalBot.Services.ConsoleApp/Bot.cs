using System.Configuration;
using Telegram.Bot;

namespace PersonalBot.Services.ConsoleApp
{
    public static class Bot
    {
        public static readonly TelegramBotClient Api = new TelegramBotClient(ConfigurationManager.AppSettings["ChatBotToken"]);
    }
}
