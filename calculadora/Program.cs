using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");
            double result = 0;
            int num1 = 0, num2 = 0;
            string oper;
            
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

           
            

            switch(oper){
                case "+" :
                     Console.WriteLine( result = num1 + num2);
                break;

                case "-":
                     Console.WriteLine(result = num1 - num2);
                break;

                case "*":
                   Console.WriteLine( result = num1 * num2);
                break;

                case "/":
                    Console.WriteLine( result = num1 / num2);
                break;

                case "%":
                    Console.WriteLine( result = num1 % num2);
                break; 

                default:
                    Console.WriteLine("Operação Invalida");   
                break;    


            }
             

            


        }
    }
}
