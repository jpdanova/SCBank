using SCBank;

Funcionario funcionarioObj = new Funcionario();
funcionarioObj.Preencher();
funcionarioObj.Imprimir();

Cliente clienteObj = new Cliente();
clienteObj.Preencher();
clienteObj.Imprimir();
clienteObj.SetCpf("15678900");
clienteObj.Imprimir();
clienteObj.SetCpf("03903277002");
clienteObj.Imprimir();

Cliente clienteObj2 = new Cliente();
clienteObj2.Preencher();
clienteObj2.Imprimir();

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(clienteObj);
pessoas.Add(funcionarioObj);
pessoas.Add(clienteObj2);

Pessoa pessoaCliente = clienteObj;
Pessoa pessoaFuncionario = funcionarioObj;

Cliente cliente2 = (Cliente)pessoaCliente;

cliente2.End = "Rua das Flores, 123";

Console.WriteLine("Matrícula do funcionário é: " + ((Funcionario)pessoaFuncionario).NumeroMatricula);

foreach (var pessoa in pessoas)
{
    pessoa.Imprimir();

    if (pessoa.GetType() == typeof(Cliente))
    {
        Console.WriteLine($"{pessoa.Nome} é um cliente e tem o endereço: {cliente2.End}");
    }
    else
    {
        Console.WriteLine($"{pessoa.Nome} é um funcionário e tem a matrícula: {((Funcionario)pessoa).NumeroMatricula}");
    }
}



var contaDoClienteObj = new Conta(clienteObj, funcionarioObj);
contaDoClienteObj.Depositar(1000);
contaDoClienteObj.Sacar(500);
contaDoClienteObj.ImprimirExtrato();

var contaDaMaria = new Conta(clienteObj2, funcionarioObj);
contaDaMaria.Depositar(2000);
contaDaMaria.Sacar(500);
contaDaMaria.ImprimirExtrato();

contaDoClienteObj.Depositar(5000);
contaDoClienteObj.ImprimirExtrato();

var saldoContaDoClienteObj = contaDoClienteObj.ObterSaldo();
Console.WriteLine($"Saldo da conta do {contaDoClienteObj.Titular.Nome}: {saldoContaDoClienteObj:C}");