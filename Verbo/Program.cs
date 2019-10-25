using System;

namespace Verbo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Verbo;
            System.Console.WriteLine("Digite um verbo no Infinitivo:");
            Verbo = Console.ReadLine();
            string let = Verbo.Substring(Verbo.Length - 2, 2);
            switch (let)
            {
                case "ar":
                    System.Console.WriteLine($"O {Verbo} ta na 1º conjugaçao ");
                    break;
                case "er":
                    System.Console.WriteLine($"O {Verbo} ta na 2º conjugaçao ");
                    break;
                case "ir":
                    System.Console.WriteLine($"O {Verbo} ta na 3º conjugaçao ");
                    break;
            }

        }
    }
}
