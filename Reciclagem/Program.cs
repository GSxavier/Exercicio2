using System;
using System.Collections.Generic;
using Reciclagem.Models;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("-----------Bem Vindo a Reciclagem------------");
            System.Console.WriteLine(" 1 - Garrafa");
            System.Console.WriteLine(" 2 - Garrafa PET");
            System.Console.WriteLine(" 3 - Guarda Chuva");
            System.Console.WriteLine(" 4 - Latinha");
            System.Console.WriteLine(" 5 - Papelao");
            System.Console.WriteLine(" 6 - Pote de Manteiga");
            System.Console.WriteLine("Digite o numero do lixo a ser jogado: ");
            int Lixos = int.Parse(Console.ReadLine());

            

            do
            {

                switch (Lixos)
                {
                    case 1:
                        Garrafa lixo = new Garrafa();
                        lixo.Lixao();
                        break;
                    case 2:
                        GarrafaPET pet = new GarrafaPET();
                        pet.Lixao();
                        break;
                    case 3:
                        GuardaChuva inder = new GuardaChuva();
                        inder.Lixao();
                        break;
                    case 4:
                        Latinha lata = new Latinha();
                        lata.Lixao();
                        break;
                    case 5:
                        Papelao papel = new Papelao();
                        papel.Lixao();
                        break;
                    case 6:
                        PoteManteiga mante = new PoteManteiga();
                        mante.Lixao();
                        break;
                    default:
                        System.Console.WriteLine("Comando Invalido!");
                        break;
                }
                


            } while ((Lixos > 6) && (Lixos <= 0) );




        }
    }
}
