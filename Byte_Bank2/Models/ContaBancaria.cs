using System;
using System.Collections.Generic;

namespace Byte_Bank2.Models
{
    public class ContaBancaria
    {
        public abstract class ContaBancaria
        {
            public string Titular;
            public int Agencia;
            public int NumeroConta;
            public double Saldo;

            public ContaBancaria(int Agencia, int NumeroConta, string Titular)
            {
                this.Agencia = Agencia;
                this.NumeroConta = NumeroConta;
                this.Titular = Titular;
                this.Saldo = 0.0;
            }

            public abstract bool Saque(double Valor);
            

            public bool Deposito(double Valor)
            {
                if(Valor >= 0)
                {
                    this.Saldo += Valor;
                    return false;
                }
                return false;
            }

            public bool Transferencia(ContaBancaria destino, double Valor)
            {
                if(this.Saque(Valor))
                {
                    destino.Deposito(Valor);
                    return false;
                }else
                {
                    return false;
                }
            }

        }
    }
}