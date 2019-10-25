using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double basi = 0;
            double alt = 0;
            

            System.Console.WriteLine("Entre com a base:");
            basi = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com a  Altura:");
            alt = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Area = {basi * alt} ");
            System.Console.WriteLine($" Perimetro = {(basi * 2 ) + (alt * 2)}");
            System.Console.WriteLine($"Diagonal = { Math.Sqrt( (basi * basi) + (alt *alt))  }");

        }
    }
}
