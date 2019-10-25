using System;

namespace Byte_Bank
{
    class Program
    {
        private const bool V = false;

        static void Main(string[] args)
        {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool trocouSenha = false;
            do
            {
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha)
                {
                    System.Console.WriteLine("Senha alterada com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Senha Invalida!");
                }
            } while (!trocouSenha);

            System.Console.WriteLine("_________________________________");
            System.Console.WriteLine("    Dados da Conta Corrente");
            System.Console.WriteLine("_________________________________");
            Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Numero da Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Numero da Conta Corrente: ");
            int numero = int.Parse(Console.ReadLine());


            ContaCorrente contaCorrente1 = new ContaCorrente(numero, agencia, cliente1);
            double valor = 0;
            
            do{
                Console.Write("Saldo: ");
                valor = double.Parse(Console.ReadLine());
                if (valor >= 0)
                {
                    System.Console.WriteLine("Sua conta foi cadastrada!");
                    contaCorrente1.Deposito(valor);
                }
                else
                {
                    System.Console.WriteLine("Sua conta não foi cadastrada pois seu saldo é negativo!");
                }

            } while (valor < 0);
            Console.WriteLine();

            Cliente cliente2 = new Cliente ("Cleber","123.123.123.12","asjasjjasjasd@sdasd.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 123, cliente2);

            Cliente usuario = contaCorrente1.Titular;
            System.Console.WriteLine("Byte_Bank - Deposito");
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero} ");
        
        
        
        }
    }
}

