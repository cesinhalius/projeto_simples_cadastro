
using System.Collections.Generic;

namespace Games.Interface
{
    public interface IRepositorio<G>
    {
         List<G> Lista();
         G RetornaporId(int id);
        void Insere(G entidade);
        void Exclui(int id);
        void Atualizar(int id, G entidade);
        int ProximoId();
    }
}