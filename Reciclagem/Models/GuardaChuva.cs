using System;
using Reciclagem.interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : DescarteEspecial
    {
        

        public void Lixao()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Garrafa deve ser jogado na lixeira CINZA");
            Console.BackgroundColor = ConsoleColor.Black;
            
        }
    }
}