using System;

namespace Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
             int ano = 0;

        do{   
            Console.WriteLine("Fale o ano em que você nasceu: ");
            ano = int.Parse(Console.ReadLine());
            if((ano > 2021) || (ano < 0)){
                Console.WriteLine("Data invalida burro");
            }
        } 

        while((ano > 2021) || (ano < 0));


            int idade= 0;
            idade = 2019 - ano;
            
            Console.WriteLine("Sua idade é: " + idade);
            
      
                if(idade <= 2){
                    Console.WriteLine("Voce é: Recem-Nascido ");
                }

                else if(idade >= 3 && idade <= 11){
                    Console.WriteLine("Voce é: Criança");
                }  

                else if(idade >= 12 && idade <= 19){
                    Console.WriteLine("Voce é: Adolescente");
                }         

                else if(idade >= 20 && idade <= 65){
                    Console.WriteLine("Voce é: Adulto");
                }

                else{
                    Console.WriteLine("Voce é: Pré historico");
                }
            
        }
    }
}
