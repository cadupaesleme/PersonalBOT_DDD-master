using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
   public class AtividadeService: IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;

       

        public AtividadeService(IAtividadeRepository atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }
        public List<Atividade> getAtividades()
        {
            
            return _atividadeRepository.GetAtividades();
        }


       

    }
}
