/* Imagine que você está criando um programa para mostrar a tabela de multiplicação de um número específico. 
Neste exercício, o número escolhido será o 7, e a ideia é gerar a tabela de multiplicação de 7, de 1 até 10, usando um laço de repetição. 
O que você deve fazer é escrever um programa que utilize um laço de repetição para imprimir a tabela de multiplicação do número 7. 
O programa deve exibir o resultado de cada multiplicação, conforme o exemplo abaixo.

Saída esperada:

7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70 */

int numero = 7;
for(int i = 1; i <= 10; i++) {
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}