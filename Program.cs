﻿using Banking_app_project.Entidades;
using Banking_app_project.Entidades.Exceptions;
using Banking_app_project.Servicos;
using System.Linq;

namespace Banking_app_project {
    internal class Program {
        static void Main(string[] args) {

            SortedSet<Conta> Set = new SortedSet<Conta>(); // guardar as contas dos dois tipo
            Set.Add(new ContaComum("9999999999", "Rafael Yamada", "rafa@gmail.com", "4132", new Carteira()));

            Console.WriteLine("CADASTRO: ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Informe o tipo de conta: ");
            string TipoConta = Console.ReadLine();

            var Conta = FacMethod.InstanciarConta(TipoConta); // Upcasting

            if (TipoConta.ToUpper().Equals("COMUM")) { // Efeito comparativo com caixa alta
                Console.Write("Digite o Email: ");
                string Email = Console.ReadLine();
                Console.Write("CPF: ");
                string Cpf = Console.ReadLine();
                Console.Write("Digite a senha: ");
                string Senha = Console.ReadLine();
                Conta = new ContaComum(Cpf, Nome, Email, Senha, new Carteira()); //Fenômeno do upcasting
                Set.Add(Conta);
            }
            else if (TipoConta.ToUpper().Equals("LOJISTA")) {
                Console.Write("Digite o Email: ");
                string Email = Console.ReadLine();
                Console.Write("CPNJ: ");
                string Cnpj = Console.ReadLine();
                Console.Write("Digite a senha: ");
                string Senha = Console.ReadLine();
                Conta = new ContaLojista(Cnpj, Nome, Email, Senha, new Carteira()); //Fenômeno do upcasting
                Set.Add(Conta);
            }
            Console.WriteLine(Conta.Email);
            Console.Write("Informe a quantia de depósito inicial: ");
            double Quantia = double.Parse(Console.ReadLine());
            Console.Write("Confirme a senha: ");
            string SenhaConf = Console.ReadLine();

            if (SenhaConf.Equals(Conta.Senha)) {  // Sem ToUpper() pois a senha precisa bater 100% da caixa alta/baixa.
                DepositarServico Dep = new DepositarServico();
                Dep.Depositar(Conta, Quantia);
                Console.WriteLine("Depósito realizado, saldo atual " + Conta.Carteira.Saldo); // Mostra o depósito inicial
            }

            if (Conta is ContaComum) {

                Console.Write("Informe a quantia que você irá transferir: ");
                int Valor = int.Parse(Console.ReadLine());
                Console.Write("Informe a chave pix (Email) da conta recebente: ");
                string Chave = Console.ReadLine();
                foreach (var Item in Set) {
                    if (Item.Email.Equals(Chave)) {
                        try {
                            Conta Origem = Item;
                            TransferenciaServico Transf = new TransferenciaServico();
                            Transf.Transferencia(Conta, Item, Valor);
                            Console.WriteLine("Transferência realizada.");
                        }
                        catch (ContaException Ex) {
                            Console.WriteLine(Ex.Message);
                        }
                    }
                }
            }
        }
    }
}
