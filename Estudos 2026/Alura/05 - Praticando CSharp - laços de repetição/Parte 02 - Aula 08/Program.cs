/* Você está desenvolvendo uma ferramenta de análise de dados que permite ao usuário inserir 10 números inteiros, um por vez. 
O objetivo é contar quantos desses números são ímpares e, ao final, exibir o total de números ímpares digitados.

Para isso, você precisará de um programa que:

    Solicite ao usuário a inserção de 10 números inteiros.
    Verifique, para cada número, se ele é ímpar.
    Conte quantos números ímpares foram digitados.
    Exiba o total de números ímpares ao final.

Exemplo de entrada:

Digite um número: 2
Digite um número: 3
Digite um número: 5
Digite um número: 7
Digite um número: 10
Digite um número: 12
Digite um número: 15
Digite um número: 17
Digite um número: 20
Digite um número: 21

Saída esperada:

Você digitou 6 números ímpares. */

int cont = 0;
for(int i = 0; i < 10; i++) {
    Console.Write("Digite um número: ");
    int digite = int.Parse(Console.ReadLine());
    if(digite % 2 != 0) {
        cont++;
    }
}
Console.WriteLine($"Você digitou {cont} números ímpares.");