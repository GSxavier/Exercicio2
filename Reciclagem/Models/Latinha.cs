using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Metal
    {
        

        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            
            System.Console.WriteLine("Garrafa deve ser jogado na lixeira AMARELA");
            Console.BackgroundColor = ConsoleColor.Black;
            
        }
    }
}