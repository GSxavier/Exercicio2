using System;

namespace Matriz3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int colun = 3;
            int filei = 3;    

            int valor;
            Random numr = new Random();
            int[,] mat = new int[colun,filei];

            for (int i = 0; i < filei; i++)
            {   
                for (int p = 0; p < colun; p++)
                {
                    valor = numr.Next(100);
                    mat [i,p] = valor;
                    System.Console.WriteLine($"Coluna{p+1} Fileira{i+1} {valor}");

                }
            }
        }
    }
}
