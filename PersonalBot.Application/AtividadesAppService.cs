using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Application
{
   public  class AtividadeAppService: IAtividadeAppService
    {
        private readonly AtividadeService _atividadeoService;

        public List<Atividade> getAtividades()
        {
            return _atividadeoService.getAtividades();
        }
    }
}
