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

        public static Funcionario CriarEPreencherFuncionario()
        {
            Funcionario funcionarioObj = new Funcionario();
            funcionarioObj.Preencher();
            return funcionarioObj;
        }


        public override void Preencher()
        {
            base.Preencher();
            Console.WriteLine("Cadastro de Funcionário");
            Console.Write("Digite a função: ");
            Funcao = Console.ReadLine();

        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Matrícula: " + NumeroMatricula);
            Console.WriteLine("Função: " + Funcao);
        }
    }
}