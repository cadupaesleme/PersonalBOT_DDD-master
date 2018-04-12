using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using PersonalBot.Application;

namespace PersonalBot.Services.ConsoleApp
{
    public class Conversa
    {
        public static bool noTreino = false;
        public static int qtdTreino = 0;
        public static int MaxqtdTreino = 0;
        public static string TreinoAtivo = "";
        public static IList<Usuario> Usuarios = new List<Usuario>();
        public static Dictionary<long, DateTime> TimerIDs = new Dictionary<long, DateTime>();
        Timer aTimer = new Timer();
        public static List<Opcao> OpcoesAtividade = new List<Opcao>();
        private IAparelhoAppService _aparelhoAppService;
        private IAtividadeAppService _atividadeAppService;
        private IFluxoAppService _fluxoAppService;

        public Conversa(IAparelhoAppService aparelhoAppService, IAtividadeAppService atividadeAppService, IFluxoAppService fluxoAppService)
        {
            _aparelhoAppService = aparelhoAppService;
            _atividadeAppService = atividadeAppService;
            _fluxoAppService = fluxoAppService;            
        }

        internal void Processar(int id, User from, Chat chat, string text)
        {
            Usuario Usuario;

            if (Usuarios.FirstOrDefault(u => u.Chat == id) == null)
            {
                Usuarios.Add(new Usuario(from.FirstName, id, _fluxoAppService.NovoFlux()));
                Usuario = Usuarios.FirstOrDefault(u => u.Chat == id);

            }
            else
            {
                Usuario = Usuarios.FirstOrDefault(u => u.Chat == id);
                // FluxoAppService FServ = new FluxoAppService(_atividadeAppService, _aparelhoAppService);
                Usuario.Fluxo.Atual = _fluxoAppService.MudarPasso(Usuario.Fluxo.Atual, text.Split(' ').First());
            }

            var fluxoAux = Usuario.Fluxo.Atual;

            if (fluxoAux.Nome == "Fim")
            {
                Usuarios.Remove(Usuario);
            }

            dynamic rkm = new ReplyKeyboardMarkup();

            if (fluxoAux.Opcoes.Count > 0)
            {

                rkm = new ReplyKeyboardMarkup();

                var rows = new List<KeyboardButton[]>();
                var cols = new List<KeyboardButton>();
                for (var Index = 0; Index < fluxoAux.Opcoes.Count; Index++)
                {
                    cols.Add(new KeyboardButton("" + fluxoAux.Opcoes[Index].Nome));
                    //if (Index % 4 != 0) continue;
                    rows.Add(cols.ToArray());
                    cols = new List<KeyboardButton>();
                }
                rkm.Keyboard = rows.ToArray();                
            }
            else
                rkm = new ReplyKeyboardRemove();

            var aux = fluxoAux.Pergunta.Split('|');

            if (aux.Count() > 1)
            {

                OpcoesAtividade = fluxoAux.Opcoes;
                TimerIDs.Remove(id);
                TimerIDs.Add(id, DateTime.Now);
                var imagem = aux[1];
                var FileUrl = Directory.GetCurrentDirectory() + @"\..\..\imagens\" + imagem.Replace("\r\n", "");

                using (var stream = System.IO.File.Open(FileUrl, FileMode.Open))
                {
                    FileToSend fts = new FileToSend();
                    fts.Content = stream;
                    fts.Filename = FileUrl.Split('\\').Last();
                    var test = Bot.Api.SendPhotoAsync(id, fts, fluxoAux.Pergunta.Split('|')[0],
                       replyMarkup: rkm).GetAwaiter().GetResult();

                }
            }
            else
            {
                TimerIDs.Remove(id);
                string msg = fluxoAux.Pergunta;

                msg = msg.Replace("{{usuario}}", Usuario.Nome);

                Bot.Api.SendTextMessageAsync(
                        id,
                        msg,
                        replyMarkup: rkm);
            }
        }

        public static List<string> MensagensMotivacionais = new List<string>();
        public static string SorteiaMensagemMotivacional()
        {
            MensagensMotivacionais = new List<string>();
            MensagensMotivacionais.Add("Vamos PORRA !!");
            MensagensMotivacionais.Add("BIRRL !!");
            MensagensMotivacionais.Add("Anda logo {{usuario}}, torre suas calorias e não a minha paciência !!");
            MensagensMotivacionais.Add("Dor é só uma palavra pra mim !!");
            MensagensMotivacionais.Add("Assim vai morrer fraco !!");
            MensagensMotivacionais.Add("Tá muito frango, tá na fisioterapia, {{usuario}}?");
            Random rnd = new Random();
            int r = rnd.Next(MensagensMotivacionais.Count);

            return MensagensMotivacionais[r];
        }

        public static async void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Dictionary<long, DateTime> timermanter = new Dictionary<long, DateTime>();

            dynamic rkm = new ReplyKeyboardMarkup();

            //rkm = new ReplyKeyboardRemove();

            var rows = new List<KeyboardButton[]>();
            var cols = new List<KeyboardButton>();
            for (var Index = 0; Index < OpcoesAtividade.Count; Index++)
            {
                cols.Add(new KeyboardButton("" + OpcoesAtividade[Index].Nome));
                //if (Index % 4 != 0) continue;
                rows.Add(cols.ToArray());
                cols = new List<KeyboardButton>();
            }
            rkm.Keyboard = rows.ToArray();

            foreach (var item in TimerIDs)
            {
                var dataVerificacao = item.Value.AddSeconds(10);
                if (DateTime.Now >= dataVerificacao)
                {
                    //TimerIDs.Remove(item.Key);
                    //TimerIDs.Add(item.Key, DateTime.Now);
                    //TimerIDs[item.Key] = DateTime.Now;

                    //sorteia palavras motivacionais
                    //FluxoService fServ = new FluxoService();
                    string msg = SorteiaMensagemMotivacional();
                    msg = msg.Replace("{{usuario}}", Usuarios.FirstOrDefault(a => a.Chat == item.Key).Nome);

                    Bot.Api.SendTextMessageAsync(
                              item.Key,
                              msg,
                              replyMarkup: rkm);

                    timermanter.Add(item.Key, DateTime.Now);
                }
                else
                {
                    timermanter.Add(item.Key, item.Value);
                }
            }
            TimerIDs = timermanter;
        }
    }
}
