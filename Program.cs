using SCBank;

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

var contaDoArthur = new Conta("Arthur");

contaDoArthur.Depositar(1000);
contaDoArthur.Sacar(500);
contaDoArthur.ImprimirExtrato();

var contaDaMaria = new Conta("Maria");

contaDaMaria.Depositar(2000);
contaDaMaria.Sacar(500);
contaDaMaria.ImprimirExtrato();

contaDoArthur.Depositar(5000);
contaDoArthur.ImprimirExtrato();

var saldoContaDoArthur = contaDoArthur.ObterSaldo();
Console.WriteLine($"Saldo da conta do Arthur: {saldoContaDoArthur:C}");

var contaDoJoao = new Conta();

contaDoJoao.Titular = "João";
contaDoJoao.ImprimirExtrato();