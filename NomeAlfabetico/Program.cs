using System;

namespace NomeAlfabetico
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            System.Console.WriteLine("Digite o Primeiro nome:");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Digite o Segundo nome:");
            nome2 = Console.ReadLine();

            int comp = string.Compare(nome1, nome2);
            if(comp < 0)
            {
                System.Console.WriteLine($"1-{nome1} 2-{nome2}");
            }
            else{
                System.Console.WriteLine($"1-{nome2} 2-{nome1}");
            }
        }
    }
}
