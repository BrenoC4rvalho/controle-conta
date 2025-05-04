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

        public string IdadeEmRomanos()
        {
            return ConverterParaRomano(DateTime.Now.Year - anoNascimento);
        }

        private string ConverterParaRomano(int numero)
        {
            if (numero <= 0) return "";

            string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string resultado = "";

            for (int i = 0; i < valores.Length; i++)
            {
                while (numero >= valores[i])
                {
                    resultado += romanos[i];
                    numero -= valores[i];
                }
            }

            return resultado;
        }

    }
}
