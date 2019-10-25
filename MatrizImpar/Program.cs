using System;

namespace MatrizImpar
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] vetor = {1,2,3,4,5,6};
           int par = 0;
           int impar = 0;


           
           
           
           Console.WriteLine("Digite os numeros nos vetores ! ");
           for(int i = 0; i < 6; i++){
             Console.WriteLine($"Digite o {i+1} numero: ");
             vetor[i] = Convert.ToInt32(Console.ReadLine());
           }
            for(int i = 0; i < 6; i++){
                if(vetor[i] % 2 == 0){
                    par ++;
                }
            }
            impar = 6 - par;
            Console.WriteLine("A quantidade de numeros impares é: " + impar);
            Console.WriteLine("A quantidade de numeros pares é: " + par);
        }
    }
}
