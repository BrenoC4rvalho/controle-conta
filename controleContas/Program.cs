// See https://aka.ms/new-console-template for more information

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar banco
            Banco banco = new Banco("001", "Banco Legal");

            // Criar agências
            Agencia agencia1 = CriarAgencia("1001", "12345678", "(11)99999-9999", banco);
            Agencia agencia2 = CriarAgencia("1002", "87654321", "(21)98888-8888", banco);

            // Criar clientes (maiores de 18)
            Cliente cliente1 = CriarCliente("Ana", "12345678901", 1990);
            Cliente cliente2 = CriarCliente("Bruno", "98765432100", 1985);
            Cliente cliente3 = CriarCliente("Carlos", "11122233344", 1995);

            // Imprimir idade dos clientes em romanos
            Console.WriteLine($"Idade de {cliente1.NomeProp}: {cliente1.IdadeEmRomanos()}");
            Console.WriteLine($"Idade de {cliente2.NomeProp}: {cliente2.IdadeEmRomanos()}");
            Console.WriteLine($"Idade de {cliente3.NomeProp}: {cliente3.IdadeEmRomanos()}");

            // Criar contas (saldo inicial válido)
            Conta conta1 = CriarConta(1, 1000m, cliente1, agencia1);
            Conta conta2 = CriarConta(2, 2000m, cliente2, agencia1);
            Conta conta3 = CriarConta(3, 3000m, cliente3, agencia2);
            Conta conta4 = CriarConta(4, 4000m, cliente1, agencia2);

            // Operações
            Console.WriteLine("\n--- DEPÓSITO ---");
            conta1.Deposito(500m);
            MostrarSaldo(conta1);

            Console.WriteLine("\n--- SAQUE ---");
            conta2.Saque(150m);
            MostrarSaldo(conta2);

            Console.WriteLine("\n--- TRANSFERÊNCIA ---");
            conta3.Transferencia(conta4, 1000m);
            MostrarSaldo(conta3);
            MostrarSaldo(conta4);

            Console.WriteLine("\n--- CONTA COM MAIOR SALDO ---");
            Conta contaMaior = Conta.ObterContaComMaiorSaldo();
            Console.WriteLine($"Conta {contaMaior.NumeroProp}, Titular: {contaMaior.ClienteProp.NomeProp}, Saldo: {contaMaior.SaldoProp:C2}");

            Console.WriteLine("\n--- SALDO TOTAL DE TODAS AS CONTAS ---");
            Console.WriteLine($"Saldo total: {Conta.ObterSaldoTotalDasContas():C2}");

            Console.ReadLine();
        }

        static Agencia CriarAgencia(string numero, string cep, string telefone, Banco banco)
        {
            return new Agencia(numero, cep, telefone, banco);
        }

        static Cliente CriarCliente(string nome, string cpf, int anoNascimento)
        {
            return new Cliente(nome, cpf, anoNascimento);
        }

        static Conta CriarConta(int numero, decimal saldoInicial, Cliente titular, Agencia agencia)
        {
            return new Conta(numero, saldoInicial, titular, agencia);
        }

        static void MostrarSaldo(Conta conta)
        {
            Console.WriteLine($"Conta {conta.NumeroProp}, titular: {conta.ClienteProp.NomeProp}, saldo: {conta.SaldoProp:C2}");
        }
    }
}