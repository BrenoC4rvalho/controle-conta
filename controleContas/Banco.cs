using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Banco
    {
        private string numero;
        private string nome;

        public Banco(string numero, string nome)
        {
            this.numero = numero;
            this.nome = nome;
        }

        public string NumeroProp
        {
            get => numero; 
            set => numero = value;
        }

        public string NomeProp
        {
            get => nome;
            set => nome = value;
        }
    }
}
