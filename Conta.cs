namespace SCBank
{
    public class Conta
    {
        //construtor
        public Conta()
        {
            Numero = new Random().Next();
        }
        public Conta(string titular) : this()
        {
            Titular = titular;
        }
        //atributos
        public int Numero { get; set; }
        public string Titular { get; set; }
        private decimal saldo;

        private List<Transacao> transacoes = new List<Transacao>();

        //métodos
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
            foreach (var transacao in transacoes)
            {
                transacao.ImprimirTransacao();
            }
        }
        public void ImprimirExtrato()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Número da conta: " + Numero);
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine($"Saldo atual: {saldo:C2}");
            ImprimirTransacoes();
            Console.WriteLine("======================");
        }
    }
}