/* Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:



Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

Exemplos de Entrada	Exemplos de Saída
7 14 106

106 eh o maior

217 14 6

217 eh o maior */

using System;

class Program {
    static void Main(string[] args) {
        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        int C = int.Parse(valores[2]);

        int maiorAB = ((A + B) + Math.Abs(A - B)) / 2;
        int maiorFinal = ((maiorAB + C) + Math.Abs(maiorAB - C)) / 2;

        Console.WriteLine($"{maiorFinal} eh o maior");
    }
}