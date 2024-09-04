using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE FUNCIONÁRIO *** \n");

                #region CAPTURAR DADOS DOS FUNCIONÁRIOS

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("NOME DO FUNCINÁRIO: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DATA DE NASCIMENTO: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("CPF: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("MATRÍCULA: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DATA DE ADMISSÃO: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
                #endregion

                #region
                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();

                Console.Write("SIGLA DO SETOR: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("DESCRIÇÃO DO SETOR: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFALHA AO CADASTRAR: {e.Message}");

            }
        }
    }
}
