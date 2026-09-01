namespace SCBank
{
    public class Funcionario : Pessoa
    {

        public int NumeroMatricula { get; set; }
        public string Funcao { get; set; }

        public Funcionario()
        {
            NumeroMatricula = new Random().Next();
        }


        public void Preencher()
        {
            Console.Write("Digite o nome do funcionário: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            Telefone = Console.ReadLine();

            Console.Write("Digite a função: ");
            Funcao = Console.ReadLine();

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
            Console.WriteLine("Função: " + Funcao);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
        }
    }
}