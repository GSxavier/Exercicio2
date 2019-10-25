using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente clientes1 = new cliente("Alberto", "55 55 55555-55555", "asdf@gmail.com");

            Console.WriteLine("Nome: " + clientes1.Nome);
            Console.WriteLine("Telefone: " + clientes1.Telefone);
            Console.WriteLine("Email: " + clientes1.Email);
            
        }
    }
}
