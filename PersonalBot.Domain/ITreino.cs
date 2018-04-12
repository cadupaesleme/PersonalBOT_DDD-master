using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public interface ITreino
    {
        Guid Id { get; set; }
        string Nome { get; set; }
        IList<Atividade> Atividades { get; set; }
    }
}
