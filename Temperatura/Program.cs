using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dados = new double [12];
            double maior = 0;
            double menor = 0;
            for(int temp = 0; temp < 12; temp++ ){
             Console.WriteLine($"Digite a temperatura do mes {temp+1} : ");
             dados[temp] = double.Parse(Console.ReadLine());
            }
            maior = dados[0];
            menor = dados[0];

            foreach(double temp in dados){
                if(temp > maior){
                    maior = temp;
                }

            else if(temp < menor){
                menor = temp;
            }
          }
        Console.WriteLine($"A maior temperatura é {maior}.");
        Console.WriteLine($"A menor temperatura é {menor}.");
        }
    }
}
