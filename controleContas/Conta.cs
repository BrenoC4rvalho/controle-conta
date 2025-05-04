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
        private Cliente titular;
        private Agencia agencia;

        public Conta(int numero, decimal saldo, Cliente titular, Agencia agencia)
        {
            this.numero = numero;

            if (saldo > 10.00m)
            {
                this.saldo = saldo;
            }
            else
            {
                throw new Exception("Saldo inicial deve ser maior que 10.00");
            }

            this.titular = titular;
            this.agencia = agencia;
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

        public Cliente ClienteProp
        {
            get => titular;
            set => titular = value;
        }

        public Agencia AgenciaProp
        {
            get => agencia;
            set => agencia = value;
        }

        public void Deposito(decimal valor)
        {
            if(valor > 0.0m)
            {
                saldo += valor;
            }
        }

        public void Saque(decimal valor)
        {
            if (valor > 0.0m && (valor + 0.10m) < saldo )
            {
                saldo -= valor;
                saldo -= 0.10m; // taxa de saque
            }
            else
            {
                Console.WriteLine("Valor inválido para saque");
            }
        }

        public void Transferencia(Conta contaDestino, decimal valor)
        {
            if (valor > 0.0m && (valor) < saldo)
            {
                saldo -= valor;
                contaDestino.Deposito(valor);

                // exibir saldo das duas contas
            }
            else
            {
                Console.WriteLine("Valor inválido para transferência");
            }
        }
    }
}
