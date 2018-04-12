using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public class Aparelho
    {
        public Aparelho(int id, string nome, string imagem)
        {
            Id = id;
            Nome = nome;
            Imagem = imagem;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

    }
}
