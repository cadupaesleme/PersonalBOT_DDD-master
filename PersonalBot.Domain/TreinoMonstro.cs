using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public class TreinoMonstro : ITreino
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Atividade> Atividades { get; set; }
        //private readonly IAtividadeService _atividadeService;

        public TreinoMonstro(IAtividadeService _atividadeService)
        {
            this.Id = Guid.NewGuid();
            this.Nome = "Treino Monstro 1";
          
            this.Atividades = _atividadeService.getAtividades();
        }
    }
}
