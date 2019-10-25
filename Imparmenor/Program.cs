using System;

namespace Imparmenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            System.Console.WriteLine("Digite um numero:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i += 2)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
