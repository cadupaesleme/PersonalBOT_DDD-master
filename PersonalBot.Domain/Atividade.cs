using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Domain
{
    public enum TipoAtividade { Frango, Moderado, Monstro }
    public class Atividade
    {
        public Atividade()
        {
        }

        public Atividade(Guid id, string nome, TipoAtividade tipoAtividade, Aparelho aparelho, string descricao)
        {
            Id = id;
            Nome = nome;
            TipoAtividade = tipoAtividade;
            Aparelho = aparelho;
            Descricao = descricao;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public TipoAtividade TipoAtividade { get; set; }
        public Aparelho Aparelho { get; set; }
        public string Descricao { get; set; }




    }
}
