Titular t = new();
Conta c = new();
EstoqueDeProdutos ep = new();
Produto produto = new();

t.Nome = "George Harrison";
t.Cpf = "000.000.000-00";
t.Endereco = "Rua dos Besouros - Liverpool";

c.Titular = t;
c.Agencia = 1;
c.NumeroDaConta = 2234;
c.Saldo = 10000000.0;
c.Limite = 100000.0;

//ep.AdicionarProduto({produto.Nome});
produto.Nome = "TV";
produto.Marca = "Samsung";
produto.Preco = 2300.00;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereco: {c.Titular.Endereco}");
ep.ExibirProdutos();