using System;

namespace DuasListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int[] nmr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nmr[i] = numAleatorio.Next(1, 10);
            }

            for (int i = 0; i < 10; i++)
            {
                if (nmr[i] % 2 == 0)
                {
                    System.Console.WriteLine($"Numero par: {nmr[i]}");
                }
                else
                {

                }

            }
            for (int i = 0; i < 10; i++)
            {
                if (nmr[i] % 2 != 0)
                {
                    System.Console.WriteLine($"Numero impar: {nmr[i]}");
                }
                else
                {

                }
            }
        }
    }
}
