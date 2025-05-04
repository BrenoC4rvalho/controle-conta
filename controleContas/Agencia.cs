using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Agencia
    {
        private string numero;
        private string cep;
        private string telefone;
        private Banco banco;

        public Agencia(string numero, string cep, string telefone, Banco banco)
        {
            this.numero = numero;
            this.cep = cep;
            this.telefone = telefone;
            this.banco = banco;
        }

        public string NumeroProp
        {
            get => numero;
            set => numero = value;
        }

        public string CepProp
        {
            get => cep;
            set => cep = value;
        }

        public string TelefoneProp
        {
            get => telefone;
            set => telefone = value;
        }

        public Banco BancoProp
        {
            get => banco; 
            set => banco = value;
        }
    }
}
