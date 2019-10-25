using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Me informe 3 numeros que os colarei em ordem crescente!");
            System.Console.WriteLine ("Número 1: ");
            float num1 = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número 2: ");
            float num2 = float.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número 3: ");
            float num3 = float.Parse (Console.ReadLine ());

            if (num1 < num2 && num1 < num3 && num2 < num3) {
                System.Console.WriteLine ($"O 1º{num1} 2º{num2} 3º{num3}");
            } else if (num1 < num2 && num1 < num3 && num2 > num3) {
                System.Console.WriteLine ($"O 1º{num1} 2º{num3} 3º{num2}");
            } else if (num1 > num2 && num1 > num3 && num2 < num3) {
                System.Console.WriteLine ($"O 1º{num2} 2º{num3} 3º{num1}");
            } else if (num1 > num2 && num1 > num3 && num2 > num3) {
                System.Console.WriteLine ($"O 1º{num3} 2º{num2} 3º{num1}");
            } else if (num1 > num2 && num1 < num3 && num2 < num3) {
                System.Console.WriteLine ($"O 1º{num2} 2º{num1} 3º{num3}");
            } else if (num1 < num2 && num1 > num3 && num2 > num3) {
                System.Console.WriteLine ($"O 1º{num3} 2º{num1} 3º{num2}");
            }



        }
    }
}
