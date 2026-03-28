/* Imagine que você está desenvolvendo um sistema de análise financeira para um banco digital. 
Como parte das funcionalidades, você precisa criar um programa que avalie o estado de um saldo bancário.

Crie um programa que:

Receba um valor representando o saldo.
Verifique se esse valor é positivo, negativo ou zero.
Exiba uma mensagem indicando a situação do saldo.
Exemplo de entrada:

Digite o saldo:
-26.75

Saída esperada:

O saldo está negativo. */

Console.WriteLine("Digite o saldo: ");
double saldo = double.Parse(Console.ReadLine());
if (saldo < 0) {
    Console.WriteLine("O saldo está negativo.");
} else if (saldo > 0) {
    Console.WriteLine("O saldo está positivo.");
} else {
    Console.WriteLine("O saldo está zerado.");
}