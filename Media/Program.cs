using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");

             float num1 = 0; 
             float num2 = 0; 
             float num3 = 0; 
             float num4 = 0;
             

             Console.WriteLine("Digite sua 1º nota:");
             num1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua 2º nota:");
             num2 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua 3º nota:");
             num3 = float.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua 4º nota:");
             num4 = float.Parse(Console.ReadLine());
                          
             float media = (num1 + num2 + num3 + num4) / 4;
            

             Console.WriteLine("Sua media é: " + media);

             if (media > 7){
                 Console.WriteLine("Você é foda cara vc foi APROVADO ");
             }
            
            else if(media == 7){
                 Console.WriteLine("NA TRAVEEEEEEE mas vc  foi APROVADO!!! ");
            }
             
             else{
                 Console.WriteLine("Man se REPROVOU foi mal cara a culpa é do sistema !");
             }

            
        }
    }
}
