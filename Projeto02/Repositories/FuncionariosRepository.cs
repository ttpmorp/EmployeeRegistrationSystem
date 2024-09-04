using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public abstract class FuncionariosRepository
    {
        #region MÉTODOS ABSTRATOS

        public abstract void ExportarDados(Funcionario funcionario);

        #endregion
    }
}
