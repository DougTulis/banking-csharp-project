using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class ContaComum : Conta {

        public string Cpf { get; private set; }

        public ContaComum(string cpf, string nome, string email, string senha) : base (nome,email,senha)  {
            Cpf = cpf;
        }
    }
}
