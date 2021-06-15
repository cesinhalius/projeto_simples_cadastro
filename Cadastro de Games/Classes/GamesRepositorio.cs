
using System;
using System.Collections.Generic;
using Games.Interface;

namespace Games
{
  public class GamesRepositorio : IRepositorio<Game>
  {
      private List<Game> listaGame = new List<Game>();

    public void Atualizar(int id, Game entidade)
    {
      listaGame[id] = entidade;
    }

    public void Exclui(int id)
    {
      listaGame[id].Excluir();
    }

    public void Insere(Game entidade)
    {
      listaGame.Add(entidade);
    }

    public List<Game> Lista()
    {
     return listaGame;
    }

    public int ProximoId()
    {
      return listaGame.Count;
    }

    public Game RetornaporId(int id)
    {
      return listaGame[id];
    }
  }
}