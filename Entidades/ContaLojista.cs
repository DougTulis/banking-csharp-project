using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class ContaLojista : Conta {

        public string Cnpj { get; private set; }

        public ContaLojista() {
      
        }

        public ContaLojista(string cnpj, string nome, string email, string senha, Carteira Carteira) : base(nome, email, senha, Carteira) {
            Cnpj = cnpj;
        }

        public override bool Equals(object? obj) {
            return obj is ContaLojista lojista &&
                   Cnpj == lojista.Cnpj;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Cnpj);
        }
        public override string ToString() {
            return Nome + ", " + Cnpj;
        }

    }
}
