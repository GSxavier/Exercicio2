using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
           double escolha = 0;
        
           Console.WriteLine("Selecione um :  Quadrado(1), Triangulo(2), Circulo(3), Trapézio(4), Retangulo(5), Losango(6).");
           escolha = double.Parse(Console.ReadLine());

           double med1 = 0;
           double med2 = 0;
           double med3 = 0;
          

            
            double area = 0;
            switch(escolha){
                case 1 :
                      Console.WriteLine("Digite as medidas dos lados do quadrado: ");
                      med1 = double.Parse(Console.ReadLine());
                      Console.WriteLine("Digite as medidas dos lados do quadrado: ");
                      med2 = double.Parse(Console.ReadLine());
                     Console.WriteLine( area = med1 * med2);
                     Console.WriteLine("A area da figura é: " + area);
                break;

                case 2:
                     Console.WriteLine("Digite o valor da BASE: ");
                     med1 = double.Parse(Console.ReadLine());
                     Console.WriteLine("Digite o valor da altura: ");
                     med2 = double.Parse(Console.ReadLine());
                     Console.WriteLine(area = (med1 * med2)/2);
                     Console.WriteLine("A area da figura é: " + area);
                break;

                case 3:
                   Console.WriteLine("Digite o valor do raio: ");
                   med1 = double.Parse(Console.ReadLine());
                   
                   Console.WriteLine( area = 3.14 * (med1 * med1));
                   Console.WriteLine("A area da figura é: " + area);
                break;

                case 4:
                    Console.WriteLine("Digite o valor da base MAIOR: ");
                    med1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da base MENOR: ");
                    med2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do Altura: ");
                    med3 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = ((med1 + med2)* med3)/2);
                    Console.WriteLine("A area da figura é: " + area);
                    
                break;

                case 5:
                   Console.WriteLine("Digite o valor da largura: ");
                   med1 = double.Parse(Console.ReadLine());
                   Console.WriteLine("Digite o valor da altura: ");
                   med2 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = med1 * med2);
                    Console.WriteLine("A area da figura é: " + area);
                break; 

                case 6:
                    Console.WriteLine("Digite o valor da diagonal MAIOR: ");
                    med1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da diagonal MENOR: ");
                    med1 = double.Parse(Console.ReadLine());
                    Console.WriteLine( area = (med1 * med2 )/2);
                    Console.WriteLine("A area da figura é: " + area);
                break;

                default:
                    Console.WriteLine( "Operação invalida!");
                break;
                
            }
        }
    }
}
