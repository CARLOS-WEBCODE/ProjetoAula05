using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    public class FuncionarioLAMBDARepository : FuncionarioAbstractRepository
    {
        public override void Adicionar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public override void Atualizar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public override List<Funcionario> ObterPorDataAdmissao(DateTime? dataMin, DateTime? dataMax)
        {
            throw new NotImplementedException();
        }

        public override Funcionario ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public override List<Funcionario> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public override List<Funcionario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public override void Remover(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
