/* Imagine que você é responsável pelo setor de logística de uma loja de eletrônicos. 
Seu primeiro desafio é criar um sistema para registrar a entrada de produtos no estoque. 
Como a loja recebe mercadorias diariamente, você precisa de uma ferramenta que permita adicionar quantidades de forma ágil e que mostre o total acumulado, evitando erros manuais.

Crie um programa que:

Pergunte ao usuário se ele deseja registrar uma nova entrada.
Se sim, solicitar a quantidade e atualizar o estoque.
Repetir o processo até que o usuário decida encerrar.
Exemplo de entrada:

Deseja adicionar um produto ao estoque?
1 - Sim | 0 - Não
1

Saída esperada:

Quantidade:
5
Estoque atual: 5

Deseja continuar?
1 - Sim | 0 - Não
1

Quantidade:
10
Estoque atual: 15

Deseja continuar?
1 - Sim | 0 - Não
0

Obrigado por usar nosso sistema de estoque! */

// Primeira versão:
int escolha;
int quantidade = 0;
int estoqueAtual = 0;
Console.WriteLine("Deseja adicionar um produto ao estoque?\n1 - Sim | 0 - Não");
escolha = int.Parse(Console.ReadLine());
if (escolha == 1) {
    do {
        Console.WriteLine($"\nQuantidade: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Estoque atual: {estoqueAtual += quantidade}");
        Console.WriteLine("\nDeseja continuar?\n1 - Sim | 0 - Não");
        escolha = int.Parse(Console.ReadLine());
        //Console.ReadLine();
        //Console.Clear();
    } while (escolha != 0);
} else {
    Console.WriteLine($"Estoque atual: {estoqueAtual}");
}

Console.WriteLine("Obrigado por usar nosso sistema de estoque!\n");

// Segunda versão:
int estoque = 0;
 
Console.WriteLine("Deseja adicionar um produto ao estoque?");
Console.WriteLine("1 - Sim | 0 - Não");
int resposta = int.Parse(Console.ReadLine());
 
while (resposta == 1) {
    Console.WriteLine("Quantidade:");
    int quantidade2 = Convert.ToInt32(Console.ReadLine());
    estoque += quantidade2;
 
    Console.WriteLine($"Estoque atual: {estoque}");
 
    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1 - Sim | 0 - Não");
    resposta = int.Parse(Console.ReadLine());
}
Console.WriteLine("Obrigado por usar nosso sistema de estoque!");