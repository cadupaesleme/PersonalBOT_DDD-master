using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Application
{
    public interface IFluxoAppService
    {
       
        Passo IniciarTreino(string treinoAux);
        Passo MudarPassoTreino(Passo Atual);
        Passo Iniciar();
        List<string> MontarTreino(string treinoAux);
        Passo MudarPasso(Passo Atual, string Escolhida);
        Fluxo NovoFlux();
    }
}
