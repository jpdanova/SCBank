namespace SCBank
{
    public class Conta
    {
        //construtor
        public Conta(string titular)
        {
            Titular = titular;
            Numero = new Random().Next();
        }
        //atributos
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        //métodos
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            else
            {
                Saldo -= valor;
            }
        }
        public void ImprimirExtrato()
        {
            Console.WriteLine("======================");

            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Número da conta: " + Numero);
            Console.WriteLine("Saldo atual: " + Saldo);
        }
    }
}