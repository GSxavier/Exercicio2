using System;

namespace Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um Numero de um Mês:");
            
            
            int Mes = 0;
            Mes = int.Parse(Console.ReadLine());

            switch (Mes)
            {
                case 1:
                    System.Console.WriteLine("1-Janeiro");
                    break;
                case 2:
                    System.Console.WriteLine("2-Fevereiro");
                    break;
                case 3:
                    System.Console.WriteLine("3-Março");
                    break;
                case 4:
                    System.Console.WriteLine("4-Abril");
                    break;
                case 5:
                    System.Console.WriteLine("5-Maio");

                    break;
                case 6:
                    System.Console.WriteLine("6-Junho");

                    break;
                case 7:
                    System.Console.WriteLine("7-Julho");
                    break;
                case 8:
                    System.Console.WriteLine("8-Agosto");
                    break;
                case 9:
                    System.Console.WriteLine("9-Setembro");
                    break;
                case 10:
                    System.Console.WriteLine("10-Outubro");
                    break;
                case 11:
                    System.Console.WriteLine("11-Novembro");
                    break;
                case 12:
                    System.Console.WriteLine("12-Dezembro");
                    break;
                default:
                    System.Console.WriteLine("Esse mes nao existe");
                break;

            }

        }
    }
}
