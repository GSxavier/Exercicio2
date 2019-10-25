using System;

namespace ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");

            int nmr = 0;
            Console.WriteLine("Digite um numero: ");
            nmr = int.Parse(Console.ReadLine());
           
            while(nmr != 0){
           
                Console.WriteLine("Digite um numero ou zero para parar: ");
                nmr = int.Parse(Console.ReadLine());
            
            if(nmr % 2 != 0){
                 Console.WriteLine("Número ímpar");
            }

            else{
                Console.WriteLine("Número par.");
            }
        
        
            }
        }
    }
}
