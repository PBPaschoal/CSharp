/* Exercício 12: Ordenação de Números
 * Desenvolva um programa que solicite ao usuário inserir uma lista de números e os ordene em ordem crescente ou decrescente, conforme a escolha do usuário. */

int quantidade;
Console.Write("Quantos números deseja inserir? ");
quantidade = int.Parse(Console.ReadLine());

int[] numero = new int[quantidade];

for (int i = 0; i < quantidade; i++) {
    Console.Write("Insira um número: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Deseja contar na ordem crescente ou descrecente?");
Console.WriteLine("[1] Crescente");
Console.WriteLine("[2] Decrescente");
Console.WriteLine();
byte opcao = byte.Parse(Console.ReadLine());

if (opcao == 1) {
    Array.Sort(numero);

    Console.WriteLine("Ordem Crescente:");
    for (int i = 0; i < quantidade; i++) {
        Console.WriteLine(numero[i]);
    }
}

else if (opcao == 2)
{
    Array.Sort(numero);
    Array.Reverse(numero);

    Console.WriteLine("Ordem Decrescente:");
    for (int i = 0; i < quantidade; i++)
    {
        Console.WriteLine(numero[i]);
    }
}