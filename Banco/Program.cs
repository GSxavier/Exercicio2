using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
            int[] saque = new int[cedulas.Length];
            System.Console.WriteLine("------BEM VINDO AO CAIXA ELETRONICO------");
            System.Console.WriteLine("Digite o Valor do saque:");
            double valor = double.Parse(Console.ReadLine());

            int ind = 0;
            do
            {
                if (valor >= cedulas[ind])
                {
                    valor = valor - cedulas[ind];
                    saque[ind] = saque[ind] + 1;
                }
                if (valor < cedulas[ind]) ind++;

            } while (valor != 0);
            for (int i = 0; i < saque.Length; i++)
                if (saque[i] != 0) System.Console.WriteLine($"Notas de {cedulas[i]}: {saque[i]}");

        }
    }
}
