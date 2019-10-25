using System;

namespace ListaNint
{
    class Program
    {
        static void Main(string[] args)
        {
            int numu = 0;
            System.Console.WriteLine("Digite Quantas posiçoes:");
            numu = int.Parse(Console.ReadLine());

            int[] posi = new int[numu];

            for (int i = 1; i <= numu; i++)
            {
                System.Console.WriteLine($"Digite a {i}º posição:");
                posi[i] = int.Parse(Console.ReadLine());

            }









        }
    }
}
