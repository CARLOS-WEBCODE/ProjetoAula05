using ProjetoAula05.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Funcionario
    {
        #region Atributos

        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dataAdmissao;
        private TipoContratacao _tipo;

        #endregion 

        #region Propriedades

        public Guid Id
        {
            get => _id;
            set { _id = value; }
        }

        public string Nome
        {
            get => _nome;
            set
            {
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{6,150}$");

                if (!regex.IsMatch(value))
                    throw new ArgumentException("Nome do funcionário inválido.");

                _nome = value;
            }
        }

        #endregion
    }
}
