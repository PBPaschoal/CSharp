/* Você recebeu a missão de automatizar o sistema de estoque de uma papelaria. Cada item precisa registrar seu nome e a quantidade atual em estoque. O sistema deve permitir retirar itens, mas somente se houver quantidade suficiente disponível. Caso contrário, deve exibir uma mensagem informando a falha.

Crie uma classe chamada Produto com:

Propriedade pública Nome.
Campo privado quantidadeEstoque.
Um construtor que receba o nome e a quantidade inicial.
Um método público Retirar(int quantidade) que:
Reduz a quantidade apenas se houver estoque suficiente.
Exiba uma mensagem indicando o sucesso ou a falha da operação.
Um método ExibirEstoque() para mostrar a quantidade atual.
Exemplo de entrada:

Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);

Exemplo de saída:

Retirada de 5 unidades realizada com sucesso.
Produto: Caneta Azul
Estoque: 15
Erro: Estoque insuficiente para retirada de 30 unidades. */

Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);