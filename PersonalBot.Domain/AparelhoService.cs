using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public class AparelhoService: IAparelhoService
    {
        public List<Aparelho> lista_Aparelhos = new List<Aparelho>();
        private readonly IAparelhoRepository _aparelhoRepository;
        
        public List<Aparelho> getAparelhos()
        {
            return _aparelhoRepository.getAparelhos();
        }

        public Aparelho getAparelho(int id)
        {
            return getAparelhos().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
