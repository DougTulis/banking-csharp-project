using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal class Conta {

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Conta() {
        }

        public Conta(string nome, string email, string senha) {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

    }
}
