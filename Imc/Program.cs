using System;

namespace Imc
{
    class Program
    {
        static void Main(string[] args)
        {
             
            System.Console.WriteLine("Ola bem-vindo a Clinica do Roger");
            System.Console.WriteLine("Digite seu Nome:");
            string Nome = (Console.ReadLine());
            System.Console.WriteLine("Digite seu Peso:");
            double peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua Altura:");
            double alt = double.Parse(Console.ReadLine());
            double Imc = peso / (alt * alt);

            if (Imc < 20)
            {
                System.Console.WriteLine($"Senhor(a) {Nome} esta abaixo do peso ");
            }
            else if ((Imc == 20) && (Imc < 25))
            {
                System.Console.WriteLine($"Senhor(a) {Nome} seu peso esta normal ");
            }
            else if ((Imc == 25) && (Imc < 30))
            {
                System.Console.WriteLine($"Senhor(a) {Nome} voce esta com excesso de peso ");
            }
            else if ((Imc == 30) && (Imc < 35))
            {
                System.Console.WriteLine($"Senhor(a) {Nome} voce esta com obesidade");
            }
            else if ((Imc > 35))
            {
                System.Console.WriteLine($"Senhor(a) {Nome} obesidade mórbida ");
            }
            else{
                System.Console.WriteLine("Estranho");
            }

        }
    }
}
