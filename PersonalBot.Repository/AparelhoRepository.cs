using PersonalBot.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBot.Repository
{
    public class AparelhoRepository : IAparelhoRepository
    {
        public AparelhoRepository()
        {

        }

        public List<Aparelho> getAparelhos()
        {
            List<Aparelho> lista_Aparelhos = new List<Aparelho>();
            //lista_Aparelhos.Add(new Aparelho(1, "Supino", "Supino.jpg"));
            //lista_Aparelhos.Add(new Aparelho(2, "Remada", "Remada.jpg"));
            //lista_Aparelhos.Add(new Aparelho(3, "Cadeira Flexora", "Cadeira.jpg"));
            //lista_Aparelhos.Add(new Aparelho(4, "Abdominal supra reto", "Abdominal.jpg"));
            //lista_Aparelhos.Add(new Aparelho(5, "Lombar", "Lombar.jpg"));
            //lista_Aparelhos.Add(new Aparelho(6, "Puxada", "Puxada.jpg"));
            //lista_Aparelhos.Add(new Aparelho(7, "Leg press 45", "Leg.jpg"));

            /* Aeróbicos */
            /*lista_Aparelhos.Add(new Aparelho(1, "Esteira", "Esteira_caminhada.jpg"));             
            /*lista_Aparelhos.Add(new Aparelho(2, "Esteira", "Esteira_corrida.jpg"));*/
            lista_Aparelhos.Add(new Aparelho(1, "Esteira", "Esteira.jpg"));
            lista_Aparelhos.Add(new Aparelho(2, "Esteira", "Esteira.jpg"));
            /*lista_Aparelhos.Add(new Aparelho(3, "Bicicleta", "Bicicleta.jpg"));*/
            /*lista_Aparelhos.Add(new Aparelho(4, "Transpor", "Transpor.jpg"));*/

            /* Pernas */
            // Agachamento c/ Barra
            // Máquina Extensora
            // Bom dia
            // Máquina Flexora 
            // Hiperextensão

            lista_Aparelhos.Add(new Aparelho(6, "Barra", "AgachamentoBarra.jpg"));
            lista_Aparelhos.Add(new Aparelho(7, "Cadeira Extensora", "MaquinaExtensora.jpg"));
            lista_Aparelhos.Add(new Aparelho(8, "Barra", "BomDia.jpg"));
            lista_Aparelhos.Add(new Aparelho(9, "Máquina Flexora", "MaquinaFlexora.jpg"));
            lista_Aparelhos.Add(new Aparelho(10, "Extensora Lombar", "Hiperextensao.jpg"));

            /* Costas */
            // Puxada de Dorsais em Polia Alta
            // Pullover c/ Barra em Polia Alta
            // Remada em Polia Baixa
            // Encolhimentos c/ Barra
            // Super-Homem

            lista_Aparelhos.Add(new Aparelho(11, "Pulley", "PuxadaDorsais.jpg"));
            lista_Aparelhos.Add(new Aparelho(12, "Pulley", "PulloverBarra.jpg"));
            lista_Aparelhos.Add(new Aparelho(13, "Remada Sentada", "Remada.jpg"));
            lista_Aparelhos.Add(new Aparelho(14, "Barra", "Encolhimento.jpg"));
            lista_Aparelhos.Add(new Aparelho(15, "Livre", "SuperHomem.jpg"));

            /* Peitoral */
            // Supino Declinado c/ Halteres
            // Supino Inclinado c/ Halteres
            // Cruxifixo
            // Peck Deck
            // Flexão de Braço

            lista_Aparelhos.Add(new Aparelho(16, "Banco + Peso Livre", "SupinoDeclinado.jpg"));
            lista_Aparelhos.Add(new Aparelho(17, "Banco + Peso Livre", "SupinoInclinado.jpg"));
            lista_Aparelhos.Add(new Aparelho(18, "Banco + Peso Livre", "Cruxifixo.jpg"));
            lista_Aparelhos.Add(new Aparelho(19, "Peck Deck Fly", "PeckDeck.jpg"));
            lista_Aparelhos.Add(new Aparelho(20, "Livre", "Flexao.jpg"));

            /* Ombros */
            // Remada Vertical c/ Halteres
            // Elevações Laterais c/ Halteres
            // Elevações frontais c/ Halteres
            //Press Militar c/ Halteres

            lista_Aparelhos.Add(new Aparelho(21, "Peso Livre", "RemadaVertical.jpg"));
            lista_Aparelhos.Add(new Aparelho(22, "Peso Livre", "ElevacaoLateral.jpg"));
            lista_Aparelhos.Add(new Aparelho(23, "Peso Livre", "ElevacaoFrontal.jpg"));
            lista_Aparelhos.Add(new Aparelho(25, "Peso Livre", "PressMilitar.jpg"));

            /* Braços */
            // Extensões de tríceps em Banco Inclinado
            // Curl de Concentração
            // Curl c/ Halteres em Semi-Pronação (Martelo)
            // Flexão de Punhos em Supinação
            // Fundos entre Bancos

            lista_Aparelhos.Add(new Aparelho(27, "Banco + Peso Livre", "Curl.jpg"));
            lista_Aparelhos.Add(new Aparelho(26, "Banco Inclinado + Barra", "ExtensaoBarra.jpg"));
            lista_Aparelhos.Add(new Aparelho(28, "Peso Livre", "CurlMartelo.jpg"));
            lista_Aparelhos.Add(new Aparelho(29, "Banco + Barra", "Antebracos.jpg"));
            lista_Aparelhos.Add(new Aparelho(30, "Bancos", "Fundos.jpg"));

            /* Demais */
            // Supino Reto 
            // Puxada
            // Leg Press 45
            // Crunch em Banco Declinado
            // Afundos c/ Halteres

            lista_Aparelhos.Add(new Aparelho(33, "Banco + Barra", "SupinoReto.jpg"));
            lista_Aparelhos.Add(new Aparelho(34, "Pulley", "Puxada.jpg"));
            lista_Aparelhos.Add(new Aparelho(35, "Leg Press 45'", "Leg.jpg"));
            lista_Aparelhos.Add(new Aparelho(36, "Banco inclinado", "CrunchDeclinado.jpg"));
            lista_Aparelhos.Add(new Aparelho(37, "Peso Livre", "Afundos.jpg"));
            
            return lista_Aparelhos;
        }

        internal Aparelho getAparelho(int id)
        {
            return getAparelhos().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
