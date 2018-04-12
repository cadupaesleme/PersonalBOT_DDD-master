using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Application
{
    public interface IAtividadeAppService
    {
        List<Atividade> getAtividades();
    }
}
