namespace SCBank
{
    public class Cliente : Pessoa
    {
        public string End { get; set; }

        public void Preencher()
        {
            Console.Write("Digite o nome do cliente: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            Telefone = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            End = Console.ReadLine();

            Console.Write("Digite o email: ");
            Email = Console.ReadLine();

            while (!ValidarEmail())
            {
                Console.Write("Email inválido, digite novamente: ");
                Email = Console.ReadLine();
            }

            Console.Write("Digite o CPF: ");
            Cpf = Console.ReadLine();

            while (!ValidarCpf(Cpf))
            {
                Console.Write("CPF inválido, digite novamente: ");
                Cpf = Console.ReadLine();
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("Endereco: " + End);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
        }
    }
}