using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Vidro
    {
        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Garrafa deve ser jogado na lixeira VERDE");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}