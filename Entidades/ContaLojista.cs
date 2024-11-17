using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class ContaLojista : Conta {

        public string Cnpj { get; private set; }

        public ContaLojista(string cnpj, string nome, string email, string senha) : base(nome, email, senha) {
            Cnpj = cnpj;
        }


    }
}
