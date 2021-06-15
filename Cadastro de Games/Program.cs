using System;

namespace Games
{
    class Program
    {
        static GamesRepositorio repositorio = new GamesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario)
                {
                case "1":
                    ListarGames();
                 break;
                case "2":
                    InserirGames();
                break;
                case "3":
                   AtualizarGames();
                break;
                case "4":
                    ExcluirGames();
                break;
                case "5":
                    VisualizarGames();
                break;
                case "C":
                    Console.Clear();
                break;

                default:
                    throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static void VisualizarGames()
        {
            Console.Write("Digite o id do jogo:  ");
            int indiceJogo = int.Parse(Console.ReadLine());

            var jogo  = repositorio.RetornaporId(indiceJogo);

            Console.WriteLine(jogo);
        }

        private static void ExcluirGames()
        {
            Console.Write("Digite o id do jogo:  ");
            int indiceJogo = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceJogo);
        }
        
        private static void ListarGames()
        {
            Console.WriteLine("Listar Games");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhum Game Cadastrado");
                return;
            }

            foreach(var Game in lista){
                var excluido = Game.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}", Game.retornaId(),Game.retornaTitulo(),(excluido ? " *Excluido*" : ""));
            }
        }

        private static void InserirGames()
        {
            Console.WriteLine("Insrir novo Games: ");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();
            foreach(int t in Enum.GetValues(typeof(Tipos_Games)))
            {
                Console.WriteLine("{0}-{1}",t,Enum.GetName(typeof(Tipos_Games), t));
            }
            Console.WriteLine();

            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Tipo entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo o jogo: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da criação do jogo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do jogo: ");
            string entradaDescricao = Console.ReadLine(); 

            Game NovoGame = new Game(id: repositorio.ProximoId(),genero:(Genero)entradaGenero,
            tipo:(Tipos_Games)entradaTipo,titulo: entradaTitulo, ano:entradaAno, descricao:entradaDescricao);

            repositorio.Insere(NovoGame);
        }

        private static void AtualizarGames()
        {
            Console.Write("Digite o id do Jogo: ");
            int indiceJogo = int.Parse(Console.ReadLine());


              foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();
            foreach(int t in Enum.GetValues(typeof(Tipos_Games)))
            {
                Console.WriteLine("{0}-{1}",t,Enum.GetName(typeof(Tipos_Games), t));
            }
            Console.Write("Digite o genero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Tipo entre as opções acima: ");
            int entradaTipo = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo o jogo: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da criação do jogo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do jogo: ");
            string entradaDescricao = Console.ReadLine(); 

            Game atualizaJogo = new Game(id:indiceJogo,genero:(Genero)entradaGenero,
            tipo:(Tipos_Games)entradaTipo,titulo: entradaTitulo, ano:entradaAno, descricao:entradaDescricao);

            repositorio.Atualizar(indiceJogo, atualizaJogo);
        }

        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine();
            Console.WriteLine("Informe sua opcao desejada: ");

            Console.WriteLine("1-Listar Games");
            Console.WriteLine("2-Adicionar Games");
            Console.WriteLine("3-Atualizar Games");
            Console.WriteLine("4-Excluir Games");
            Console.WriteLine("5-Visualizar Games");
            Console.WriteLine("C-Limpar Tela");
            Console.WriteLine("X-Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;
        }

    }
}
