using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Cliente
    {

        private string nome;
        private string cpf;
        private int anoNascimento; 

        public Cliente(string nome, string cpf, int anoNascimento)
        {
            this.nome = nome;
            CPFProp = cpf;
            AnoNascimentoProp = anoNascimento;
        }

        public string NomeProp
        {
            get => nome;
            set => nome = value;
        }

        public string CPFProp
        {
            get => cpf;
            set
            {
                if (value.Length == 11)
                {
                    cpf = value;
                }
                else
                {
                    throw new Exception("CPF inválido");
                }
            }
        }

        public int AnoNascimentoProp
        {
            get => anoNascimento;
            set
            {
                if (DateTime.Now.Year - value >= 18)
                {
                    anoNascimento = value;
                }
                else
                {
                    throw new Exception("Ano de nascimento inválido");
                }
            }
        }

    }
}
