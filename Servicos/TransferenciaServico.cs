using Banking_app_project.Entidades;
using Banking_app_project.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_app_project.Servicos {
    internal class TransferenciaServico {

        public void Transferencia(Conta ContaOrigem,Conta ContaDestino, double Quantia) {
            if (ContaOrigem.Carteira.Saldo < Quantia) {
                throw new ContaException("O saldo deve ser maior que a quantia a ser transferida.");
            }
            DepositarServico Dep = new DepositarServico();
            Dep.Depositar(ContaDestino,Quantia);
            ContaOrigem.Carteira.Saldo -= Quantia;
        }
    }
}

