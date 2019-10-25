using System;

namespace TrianguloInvertido
{
    class Program
    {
        static void Main(string[] args)
        {

            int altura = 0;
            string ast = "*";
            string ast2 = "*";


            Console.WriteLine("Digite a altura do triangulo: ");
            altura = int.Parse(Console.ReadLine());
            
            while(altura != 0)
            {

            
                for (int i = altura; i != 0; i--)
                {
                    Console.Write(ast);
                    ast2 = (ast = "*");
                }
                altura --;
                System.Console.WriteLine("");
            }

            
        }
    }
}
