using Banking_app_project.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Servicos {
    internal class DepositarServico {

        public void Depositar(Conta Conta, double Quantia) {
            
            Conta.Carteira.Saldo += Quantia;
        }
    }
}
