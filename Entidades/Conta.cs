using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Entidades {
    internal abstract class Conta {

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Carteira Carteira { get; set; }

        public Conta() {
        }

        public Conta(string nome, string email, string senha, Carteira Carteira) {
            Nome = nome;
            Email = email;
            Senha = senha;
            this.Carteira = Carteira; 
        }
    }
}
