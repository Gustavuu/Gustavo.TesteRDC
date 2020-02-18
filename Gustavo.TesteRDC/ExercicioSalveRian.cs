using System.Collections.Generic;
using System.Linq;

namespace Gustavo.TesteRDC
{
    public class ExercicioSalveRian
    {
        #region Propriedades
        //Posição de sobrevivência
        int posicaoSobrevivencia;
        #endregion

        public int SalveRian(int numeroSoldados)
        {
            if (numeroSoldados > 0)
            {
                //Defino os soldados ativos para o jogo
                LinkedList<int> soldados = CriarSoldados(numeroSoldados);

                if (soldados != null && soldados.Count > 0)
                {
                    //Verifica a posição de sobrevivência
                    posicaoSobrevivencia = UltimoSoldado(soldados, soldados.First);
                }
                else
                    return 0;
            }
            else
                return 0;

            return posicaoSobrevivencia;
        }

        public LinkedList<int> CriarSoldados(int quantidade)
        {
            return new LinkedList<int>(Enumerable.Range(1, quantidade).ToList());
        }

        public int UltimoSoldado(LinkedList<int> soldados, LinkedListNode<int> atirador)
        {
            if (soldados.Count > 1)
            {
                //Verifica qual soldado será atingido
                var soldadoMorto = atirador.Next ?? soldados.First;
                //Próximo atirador
                var proximoAtirador = soldadoMorto.Next ?? soldados.First;
                //Remove o soldado atingido
                soldados.Remove(soldadoMorto);
                //Passa para a próxima posição
                return UltimoSoldado(soldados, proximoAtirador);
            }
            else
            {
                //Posição sobrevivente
                return soldados.First.Value;
            }
        }
    }
}
