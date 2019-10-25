using System;

namespace TemperaturaFire
{
    class Program
    {
        static void Main(string[] args)
        {
            double cent = 0;
        

            System.Console.WriteLine("Digite a Temperatura em Graus centigrados:");
            cent = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine($"A temperatura em  fahrenheit :{(cent * 9/5) + (32)}");
      



        }
    }
}
