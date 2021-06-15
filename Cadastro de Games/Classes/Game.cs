using System;

namespace Games
{
  public class Game : EntidadeBase
  {
      public bool retornaExcluido()
      {
        return this.Excluido;
      }
      public void Excluir(){
        this.Excluido = true;
      }
      public string retornaTitulo(){
        return this.Titulo;
      }
       public int retornaId(){
        return this.Id;
       }

      public override string ToString()
  {
    string retorno = "";
    retorno += "Gênero: " + this.Genero + Environment.NewLine;
    retorno += "Tipo: " + this.Tipo + Environment.NewLine;
    retorno += "Titulo: " + this.Titulo + Environment.NewLine;
    retorno += "Descrição: " + this.Descricao + Environment.NewLine;
    retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
    retorno += "Excluido: " + this.Excluido;
    return retorno;
  }
    public Game(int id,Genero genero, Tipos_Games tipo, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Tipo = tipo;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;
    }
    // atributos
    private Genero Genero { get; set; }
    private Tipos_Games Tipo { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido{get; set;}

  
  




     }
}