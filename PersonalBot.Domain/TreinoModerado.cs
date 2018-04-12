using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public class TreinoModerado : ITreino
    {
        public TreinoModerado(IAtividadeService _atividadeService)
        {
            this.Id = Guid.NewGuid();
            this.Nome = "Treino Moderado 1";
          
            this.Atividades = _atividadeService.getAtividades();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Atividade> Atividades { get; set; }
        //private readonly IAtividadeService _atividadeService;
    }
}
