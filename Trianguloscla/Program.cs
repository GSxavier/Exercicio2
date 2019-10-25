using System;

namespace Trianguloscla
{
    class Program
    {
        static void Main(string[] args)
        {

            int med1;
            int med2;
            int med3;
            Console.Write("Informe o 1ºlado : ");
            med1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 2ºlado : ");
            med2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o 3ºlado : ");
            med3 = Convert.ToInt32(Console.ReadLine());

            
            if ((med1 < med2 + med3) && (med2 < med1 + med3) && (med3 < med1 + med2))
            {
                Console.Write("Formam triângulo!");
            }
            if ((med1 == med2) && (med2 == med1))
            {
                Console.Write("Triângulo Equilátero");
            }
            else if ((med1 == med2) || (med2 == med3) || (med1 == med3))
            {
                Console.Write("Triângulo Isósceles");
            }
            else
            {
                Console.Write("Triângulo Escaleno");
            }






        }
    }
}
