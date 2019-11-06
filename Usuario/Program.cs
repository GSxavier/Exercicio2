using System;

namespace Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senhna;

            Console.WriteLine("Login: ");
            login = Console.ReadLine();

            Console.WriteLine("Senha: ");
            senhna = Console.ReadLine();

            if(login == "admin" && senhna == "admin"){
                Console.WriteLine("Voce conseguiu Logar como ADM!");
            } 

            else{
                Console.WriteLine("Você logou como Usuario!!");
            }
        }
    }
}
