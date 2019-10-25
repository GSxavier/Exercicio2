using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmr = 0;
            int altura = 0;
            string ast = "*";
            string ast2 = "*";

            Console.WriteLine("Digite o numero e triangulos: ");
            nmr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura dos triangulos: ");
            altura = Convert.ToInt32(Console.ReadLine());

            while (nmr != 0)
            {
                for (int i = 0; i <= altura; i++)
                {
                    Console.WriteLine(ast2);
                    ast2 += ast;
                }
                ast2 = "*";
                nmr--;

            }
        }
    }
}
