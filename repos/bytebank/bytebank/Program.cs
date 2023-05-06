using bytebank;

Cliente cliente = new Cliente("Matheus", "matheuscanovas9@gmail.com", "Analista Programador");

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.numero_agencia = 1;
conta.saldo = 2000.0;
conta.conta = "21392";