using SCBank;

var ContaDoArthur = new Conta("Arthur");

ContaDoArthur.Depositar(1000);
ContaDoArthur.Sacar(500);
ContaDoArthur.ImprimirExtrato();

var contadaMaria = new Conta("Maria");
contadaMaria.Depositar(2000);
contadaMaria.Sacar(500);
contadaMaria.ImprimirExtrato();

ContaDoArthur.Depositar(5000);
ContaDoArthur.ImprimirExtrato();