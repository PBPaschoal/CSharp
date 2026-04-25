
string nome2 = "Cadeira gamer";
string descricao2 = "Conforto ergonômico com design moderno para longas sessões de jogo.";
decimal preco2 = 600.00m;
int estoque2 = 5;

Console.WriteLine();
Console.WriteLine(@$"Dados do item 2:
Nome: {nome2};
Descrição: {descricao2};
Preço: {preco2};
Estoque: {estoque2}");

Produto item1 = new Produto();
item1.nome = "Teclado";
item1.descricao = "Modelo compacto e silencioso, perfeito para produtividade diária.";
item1.preco = 80.00m;
item1.estoque = 15;

Console.WriteLine();
Console.WriteLine(@$"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque}");

if (item1.EstaDisponivel()) {
    Console.WriteLine("O produto está disponível!");
} 

item1.AlterarPrecoComDesconto(0.2m);

Console.WriteLine();
Console.WriteLine(@$"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque}");

Produto item3 = new Produto();
item3.nome = "Mouse";
item3.descricao = "Modelo compacto e silencioso, perfeito para produtividade diária.";
item3.preco = 40.00m;
item3.estoque = 0;

Console.WriteLine();
Console.WriteLine(@$"Dados do item 3:
Nome: {item3.nome};
Descrição: {item3.descricao};
Preço: {item3.preco};
Estoque: {item3.estoque}");