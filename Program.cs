using Banking_app_project.Entidades;

namespace Banking_app_project {
    internal class Program {
        static void Main(string[] args) {

            SortedSet<Conta> Set = new SortedSet<Conta>(); // guardar as contas dos dois tipos

            Console.WriteLine("CADASTRO: ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Informe o tipo de conta: ");
            string TipoConta = Console.ReadLine();

            var Conta = FacMethod.InstanciarConta(TipoConta);

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
            Console.WriteLine(Conta.Email);
            Console.Write("Informe a quantia de depósito inicial: ");
            double quantia = double.Parse(Console.ReadLine());

        }
    }
}
