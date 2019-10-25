using System;

namespace Byte_Bank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular): base(Agencia,NumeroConta,Titular)
        {
            
        }
    }
}