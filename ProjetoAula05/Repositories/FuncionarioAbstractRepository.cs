using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    /// <summary>
    /// Classe abstrata para definir os métodos do repositorio de funcionário
    /// </summary>
    public abstract class FuncionarioAbstractRepository
    {
        #region

        protected List<Funcionario> Funcionarios { get; set; }

        #endregion

        #region Métodos abstratos

        public abstract void Adicionar(Funcionario funcionario);
        public abstract void Atualizar(Funcionario funcionario);
        public abstract void Remover(Funcionario funcionario);

        public abstract List<Funcionario> ObterTodos();
        public abstract List<Funcionario> ObterPorNome(string nome);
        public abstract List<Funcionario> ObterPorDataAdmissao(DateTime? dataMin, DateTime? dataMax);
        public abstract Funcionario ObterPorId(Guid id);

        #endregion
    }
}
