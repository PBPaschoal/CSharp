Conta conta1 = new Conta();
conta1.idConta = 0001;
conta1.nomeTitular = "Bruno Paschoal";
conta1.saldo = 75000.00;
conta1.senha = 7791;

Conta conta2 = new Conta();
conta2.idConta = 0002;
conta2.nomeTitular = "Anna";
conta2.saldo = 125000.00;
conta2.senha = 9163;

conta1.ExibirDadosConta();
conta2.ExibirDadosConta();

Carro carro1 = new Carro();
carro1.modelo = "HB20";
carro1.Buzinar();
carro1.Frear();
carro1.Acelerar();

Carro carro2 = new Carro();
carro2.modelo = "Prisma";
carro2.Acelerar();