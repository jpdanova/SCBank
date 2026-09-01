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
        public Cliente Titular { get; set; }
        public Funcionario Gerente { get; set; }
        
        public int Numero { get; set; }
        
        private decimal saldo;

        private List<Transacao> transacoes = new List<Transacao>();
        
        public void Depositar(decimal valor)
        {
            transacoes.Add(new Transacao(valor, "Depósito"));
            saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
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