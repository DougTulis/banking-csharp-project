using Banking_app_project.Entidades;

namespace Banking_app_project {
    internal class Program {
        static void Main(string[] args) {

            SortedSet<Conta> Set = new SortedSet<Conta>(); // guardar as contas dos dois tipos

            Conta Conta;
            Console.WriteLine("CADASTRO: ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Informe o tipo de conta: ");
            string TipoConta = Console.ReadLine();
            if (TipoConta.ToUpper().Equals("COMUM")) { // Efeito comparativo com caixa alta
                Console.Write("Digite o Email: ");
                string Email = Console.ReadLine();
                Console.Write("CPF: ");
                string Cpf = Console.ReadLine();
                Console.Write("Digite a senha: ");
                string Senha = Console.ReadLine();
                Conta = new ContaComum(Cpf, Nome, Email, Senha); //Fenômeno do upcasting
                Set.Add(Conta);
            }
            else if (TipoConta.ToUpper().Equals("LOJISTA")) {
                Console.Write("Digite o Email: ");
                string Email = Console.ReadLine();
                Console.Write("CPNJ: ");
                string Cnpj = Console.ReadLine();
                Console.Write("Digite a senha: ");
                string Senha = Console.ReadLine();
                Conta = new ContaComum(Cnpj, Nome, Email, Senha); //Fenômeno do upcasting
                Set.Add(Conta);
            }

            foreach (var item in Set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
