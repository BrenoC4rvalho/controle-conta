// See https://aka.ms/new-console-template for more information

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(123456);
            conta1.SaldoProp = 1235.42m;
            conta1.SaldoProp = -100m;
            Console.Read();
            Conta conta2 = new Conta(654321);
            conta2.SaldoProp = 2341.43m;

            Console.WriteLine("A conta de numero {0} tem saldo {1:C2}", conta1.NumeroProp, conta1.SaldoProp);
            Console.WriteLine("A conta de numero {0} tem saldo {1:C2}", conta2.NumeroProp, conta2.SaldoProp);

        }
    }
}