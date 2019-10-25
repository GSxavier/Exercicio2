using System;

namespace MUltiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nmr = 0;

            System.Console.WriteLine("Digite um Numero:");
            nmr = double.Parse(Console.ReadLine());

            if ( nmr % 3 == 0)
            {
                System.Console.WriteLine($"O numero e multiplo de 3");
            }
            else
            {
                System.Console.WriteLine("Não e multiplo");
            }


        }
    }
}
