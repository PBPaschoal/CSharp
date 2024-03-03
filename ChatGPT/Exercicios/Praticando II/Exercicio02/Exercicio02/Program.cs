/* Exercício 12: Ordenação de Números
 * Desenvolva um programa que solicite ao usuário inserir uma lista de números e os ordene em ordem crescente ou decrescente, conforme a escolha do usuário. */

int numero = 0;
Console.Write("Quantos números deseja inserir? ");
int quantidade = int.Parse(Console.ReadLine());
for (int i = 0; i < quantidade; i++) {
    Console.Write("Insira um número: ");
    numero = int.Parse(Console.ReadLine());
}

