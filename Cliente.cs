namespace SCBank
{
    public class Cliente : Pessoa
    {
        public string End { get; set; }

        public override void Preencher()
        {
            Console.WriteLine("Cadastro de Cliente");
            base.Preencher();
            Console.WriteLine("Digite o endereço: ");
            End = Console.ReadLine();
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Endereco: " + End);
        }
    }
}