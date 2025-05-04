using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Conta
    {
        private int numero;
        private decimal saldo; 

        public Conta(int numero)
        {
            this.numero = numero;
        }

        public int NumeroProp {
            get => numero;
            set => numero = value;
        }

        public decimal SaldoProp
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value >= 0.0m)
                {
                    saldo = value;
                } else
                {
                    Console.WriteLine("O saldo não pode ser definido como negativo");
                }
            }
        }

        public void Deposito(decimal valor)
        {
            if(valor > 0.0m)
            {
                saldo += valor;
            }
        }
    }
}
