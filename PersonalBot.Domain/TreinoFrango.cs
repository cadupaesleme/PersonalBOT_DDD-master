using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public class TreinoFrango : ITreino
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Atividade> Atividades { get; set; }
        //private readonly IAtividadeService _atividadeService;
        public TreinoFrango(IAtividadeService _atividadeservice)
        {
            this.Id = Guid.NewGuid();
            this.Nome = "Treino Frango 1";
            this.Atividades = _atividadeservice.getAtividades();
        }
    }
}
