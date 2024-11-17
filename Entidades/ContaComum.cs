using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class ContaComum : Conta {

        public string Cpf { get; private set; }



        public ContaComum(string cpf, string nome, string email, string senha) : base(nome, email, senha) {
            Cpf = cpf;

        }

        public ContaComum() {
        }

        public override bool Equals(object? obj) {
            return obj is ContaComum comum &&
                   Cpf == comum.Cpf;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Cpf);
        }

        public override string ToString() {
            return Nome + ", " + Cpf;
        }
    }
}
