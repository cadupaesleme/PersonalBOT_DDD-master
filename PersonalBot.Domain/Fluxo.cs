using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
   public class Fluxo
    {
        public Passo Atual { get; set; }
        public long ChatId { get; set; }
        public IList<string> MensagensMotivacionais { get; set; }

        //public Fluxo()
        //{
        //    FluxoService fServ = new FluxoService();
        //    Atual = fServ.Iniciar();

        //    //MensagensMotivacionais = new List<string>();
        //    //MensagensMotivacionais.Add("Vamos PORRA !!");
        //    //MensagensMotivacionais.Add("BIRRL !!");
        //    //MensagensMotivacionais.Add("Anda logo {{usuario}}, torre suas calorias e não a minha paciência !!");
        //    //MensagensMotivacionais.Add("Dor é só uma palavra pra mim !!");
        //    //MensagensMotivacionais.Add("Assim vai morrer fraco !!");
        //    //MensagensMotivacionais.Add("Tá muito frango, tá na fisioterapia {{usuario}}?");

        //}
    }
}
