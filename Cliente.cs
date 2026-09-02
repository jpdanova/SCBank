namespace SCBank
{
    public class Cliente : Pessoa
    {
        public string End { get; set; }

        public override void Preencher()
        {
            Console.WriteLine("Cadastro de Cliente");
            PreencherPai();
            Console.WriteLine("Digite o endereço: ");
            End = Console.ReadLine();
        }

        public override void Imprimir()
        {
            ImprimirPai();
            Console.WriteLine("Endereco: " + End);
        }
    }
}