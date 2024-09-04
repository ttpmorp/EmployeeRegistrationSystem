//localização da classe dentro do projeto
using Projeto02.Controllers;

namespace Projeto02
{
    //definição da classe
    public class Program
    {
        //métdo para executar o conteudo da classe
        //ponto de inicialização do projeto
        public static void Main(string[] args)
        {
            //instanciando a classe de controle
            var funcionarioController = new FuncionarioController();

            //executando o método para cadastrar funciário
            funcionarioController.CadastrarFuncionario();

            // pausar o prompt
            Console.ReadKey();
        }
    }
}