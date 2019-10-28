using System;

namespace ValoresListados
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmr = 0; 

            System.Console.WriteLine($"Digite a quantidade de numeros que voce quer que seja digitado: ");
            nmr = int.Parse(Console.ReadLine());

          
            for (int i = 0; i < nmr; i++)
            {
            Console.WriteLine($"Digite o {i + 1}º numero: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int a = 0; a < nmr; a++)
            {
                System.Console.WriteLine($"Voce digitou o numero: {numeros[a]}");
            }

        }
    }
}
