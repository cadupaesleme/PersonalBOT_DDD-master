
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using SimpleInjector;
using PersonalBot.Domain;
using PersonalBot.Application;

namespace PersonalBot.Services.ConsoleApp
{
    class Program
    {
        private static Container _container;
        private static IAparelhoAppService _aparelhoAppService;
        private static IAtividadeAppService _atividadeAppService;
        private static IFluxoAppService _fluxoAppService;

        private static Conversa _conversa;

        static void Main(string[] args)
        {
            IniciarInstancias();

            Conversa.Usuarios = new List<Usuario>();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(Conversa.OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;

            Bot.Api.OnMessage += OnMessage;
            Bot.Api.OnMessageEdited += OnMessage;

            Bot.Api.StartReceiving();

            Console.WriteLine("Serviço Personal Bot iniciado!");

            Console.ReadLine();

            Bot.Api.StopReceiving();
        }

        private static void IniciarInstancias()
        {
            _container = SimpleInjectorInitializer.Initialize();
            _aparelhoAppService = _container.GetInstance<IAparelhoAppService>();
            _atividadeAppService = _container.GetInstance<IAtividadeAppService>();
            _fluxoAppService = _container.GetInstance<IFluxoAppService>();
            _conversa = new Conversa(_aparelhoAppService, _atividadeAppService, _fluxoAppService);
        }


        private static async void OnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                    _conversa.Processar(e.Message.From.Id, e.Message.From, e.Message.Chat, e.Message.Text);
            }
            catch (Exception ex)
            {
                //TryCatch apenas na versão beta.
            }

        }

    }
}
