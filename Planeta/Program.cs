using System;

namespace Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mercúrio = 0.37;
            double Vênus = 0.88;
            double Marte = 0.38;
            double Júpiter = 2.64;
            double Saturno = 1.15;
            double Urano = 1.17;
            double peso = 0;
            double Planeta = 0;

            System.Console.WriteLine("1-Mercúrio");
            System.Console.WriteLine("2-Vênus");
            System.Console.WriteLine("3-Marte");
            System.Console.WriteLine("4-Júpiter ");
            System.Console.WriteLine("5-Saturno");
            System.Console.WriteLine("6-Urano");

            System.Console.WriteLine("Digite o Numero de um planeta planeta:");
            Planeta = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());

            switch (Planeta)
            {
                case 1:
                    System.Console.WriteLine($"O seu peso em Mercurio e:{Planeta = (peso / 10) * Mercúrio}");
                    break;
                case 2:
                    System.Console.WriteLine($"O seu peso em Venus e:{Planeta = (peso / 10) * Vênus}");
                    break;
                case 3:
                    System.Console.WriteLine($"O seu peso em Marte e:{Planeta = (peso / 10) * Marte}");
                    break;
                case 4:
                    System.Console.WriteLine($"O seu peso em Júpiter e:{Planeta = (peso / 10) * Júpiter}");
                    break;
                case 5:
                    System.Console.WriteLine($"O seu peso em Saturno e:{Planeta = (peso / 10) * Saturno }");
                    break;
                case 6:
                    System.Console.WriteLine($"O seu peso em Urano e:{Planeta = (peso / 10) * Urano}");
                    break;
                    default:
                    System.Console.WriteLine("Invalido");
                    break;

            }

        }
    }
}
