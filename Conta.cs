namespace SCBank
{
    public class Conta
    {
        public Conta(Cliente titular, Funcionario gerente)
        {
            Titular = titular;
            Gerente = gerente;
            Numero = new Random().Next();
        }

        public Cliente Titular { get; }
        public Funcionario Gerente { get; }
        public int Numero { get; }

        private decimal saldo;

        private List<Transacao> transacoes = new List<Transacao>();

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
                return;
            }

            transacoes.Add(new Transacao(valor, "Depósito"));
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
                return;
            }

            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return;
            }

            Transacao saque = new Transacao(valor, "Saque");
            transacoes.Add(saque);
            saldo -= valor;
        }

        public decimal ObterSaldo()
        {
            return saldo;
        }

        public void ImprimirTransacoes()
        {
            Console.WriteLine("Transações:");

            foreach (var transacaoObj in transacoes)
            {
                transacaoObj.ImprimirTransacao();
            }
        }

        public void ImprimirExtrato()
        {
            Titular.Imprimir();

            Console.WriteLine("======================");
            Console.WriteLine("Extrato da conta:");
            Console.WriteLine("======================");

            Console.WriteLine("Número da conta: " + Numero);
            Console.WriteLine("Titular: " + Titular.Nome);
            Console.WriteLine("CPF: " + Titular.Cpf);
            Console.WriteLine($"Saldo atual: {saldo:C2}");

            ImprimirTransacoes();

            Console.WriteLine("======================");
        }
    }
}