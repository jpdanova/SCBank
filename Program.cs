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

var contaDoClienteObj = new Conta(clienteObj);

contaDoClienteObj.Depositar(1000);
contaDoClienteObj.Sacar(500);
contaDoClienteObj.ImprimirExtrato();

var contaDaMaria = new Conta(clienteObj2);

contaDaMaria.Depositar(2000);
contaDaMaria.Sacar(500);
contaDaMaria.ImprimirExtrato();

contaDoClienteObj.Depositar(5000);
contaDoClienteObj.ImprimirExtrato();

var saldoContaDoClienteObj = contaDoClienteObj.ObterSaldo();
Console.WriteLine($"Saldo da conta do {contaDoClienteObj.Titular.Nome}: {saldoContaDoClienteObj:C}");