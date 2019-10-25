using System;

namespace Carrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            double Combu;
            double velo = 0;
            double dist ;
            double temp = 0;

            System.Console.WriteLine("Tempo do Carro:");
            temp = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Velocidade do carro");
            velo = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Distancia = {dist = (velo*temp)}");
            System.Console.WriteLine($"Combustivel gasto = {Combu = (dist/12)} litros");


        
        }
    }
}
