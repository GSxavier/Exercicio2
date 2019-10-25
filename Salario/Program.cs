using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");
            double salario = 0;
            

            Console.WriteLine("Digite o seu salario:");
            salario = int.Parse(Console.ReadLine());

            double fsalario = 0;
            if(salario <= 500.00){
                Console.WriteLine( fsalario = salario * 1.3);
                Console.WriteLine("Seu salario novo é :" + fsalario);
                }
            else{
                 Console.WriteLine("Seu salario não teve aumento!");
            }    

        }
    }
}
