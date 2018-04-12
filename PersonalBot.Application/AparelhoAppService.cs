using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Application
{
 public   class AparelhoAppService: IAparelhoAppService
    {
        private readonly AparelhoService _aparelhoService;

        public List<Aparelho> getAparelhos()
        {
            return _aparelhoService.getAparelhos();
        }
    }
}
