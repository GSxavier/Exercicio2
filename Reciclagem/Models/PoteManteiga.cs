using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class PoteManteiga : Organico
    {
        

        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Garrafa deve ser jogado na lixeira PRETA");
            
            

        }
    }
}