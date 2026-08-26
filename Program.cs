using SCBank;

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