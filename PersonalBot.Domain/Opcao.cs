using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{

    public class Opcao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Passo Passo { get; set; }
        public Passo ProximoPasso { get; set; }
    }
}
