using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        public List<Atividade> GetAtividades()
        {
            List<Atividade> lista_atividades = new List<Atividade>();
            AparelhoRepository ap = new AparelhoRepository();

            //Frango
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Caminhada", TipoAtividade.Frango, ap.getAparelho(1), "Tempo: 15'" + System.Environment.NewLine + "Velocidade 5-6 km/h" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Agachamento afundo c/ Halteres", TipoAtividade.Frango, ap.getAparelho(37), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Agachamento c/ Barra", TipoAtividade.Frango, ap.getAparelho(6), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino Inclinado c/ Halteres", TipoAtividade.Frango, ap.getAparelho(17), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Curl c/ Halteres em Semi-Pronação (Martelo)", TipoAtividade.Frango, ap.getAparelho(28), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + " Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Elevações Laterais c/ Halteres", TipoAtividade.Frango, ap.getAparelho(22), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Elevações Frontais c/ Halteres", TipoAtividade.Frango, ap.getAparelho(23), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Flexão de Punhos em Supinação", TipoAtividade.Frango, ap.getAparelho(29), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada em Polia Baixa", TipoAtividade.Frango, ap.getAparelho(13), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada", TipoAtividade.Frango, ap.getAparelho(13), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: leve" + System.Environment.NewLine + "Descanso: 1-2 min"));

            //Moderado
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Corrida", TipoAtividade.Moderado, ap.getAparelho(2), "Tempo: 15'" + System.Environment.NewLine + "Velocidade 7 - 9 km/h" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Extensora", TipoAtividade.Moderado, ap.getAparelho(7), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Flexão de Tronco", TipoAtividade.Moderado, ap.getAparelho(20), "Série: 3x de 30 repetições" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino Reto", TipoAtividade.Moderado, ap.getAparelho(33), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Bom Dia", TipoAtividade.Moderado, ap.getAparelho(8), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Leg Press", TipoAtividade.Moderado, ap.getAparelho(35), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Puxada de Dorsais em Polia Alta", TipoAtividade.Moderado, ap.getAparelho(11), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino Declinado c / Halteres", TipoAtividade.Moderado, ap.getAparelho(16), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Super-Homem", TipoAtividade.Moderado, ap.getAparelho(15), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Press Militar c/ Halteres", TipoAtividade.Moderado, ap.getAparelho(25), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: moderada" + System.Environment.NewLine + "Descanso: 1-2 min"));

            //Monstro
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Supino Reto", TipoAtividade.Monstro, ap.getAparelho(33), "Série: 2-3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Curl de Concentração", TipoAtividade.Monstro, ap.getAparelho(27), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Cruxifixo", TipoAtividade.Monstro, ap.getAparelho(18), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Crunch", TipoAtividade.Monstro, ap.getAparelho(35), "Série: 2x de 10 a 12 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Pullover c/ Barra em Polia Alta", TipoAtividade.Monstro, ap.getAparelho(12), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Extensões de Tríceps", TipoAtividade.Monstro, ap.getAparelho(26), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Flexão de Pernas", TipoAtividade.Monstro, ap.getAparelho(9), "Série: 3x de 12-15 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Encolhimentos c/ Barra", TipoAtividade.Monstro, ap.getAparelho(14), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Voadora", TipoAtividade.Monstro, ap.getAparelho(19), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Remada Vertical c / Halteres", TipoAtividade.Monstro, ap.getAparelho(21), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Hipertensão de Lombar", TipoAtividade.Monstro, ap.getAparelho(10), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));
            lista_atividades.Add(new Atividade(Guid.NewGuid(), "Fundos entre Bancos", TipoAtividade.Monstro, ap.getAparelho(30), "Série: 3x de 6-8 repetições" + System.Environment.NewLine + "Carga: elevada" + System.Environment.NewLine + "Descanso: 1-2 min"));

            return lista_atividades;
        }
    }
}
