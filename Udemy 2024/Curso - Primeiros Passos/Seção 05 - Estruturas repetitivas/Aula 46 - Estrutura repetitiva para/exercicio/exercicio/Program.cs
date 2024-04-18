/* Fazer um programa que lê um valor inteiro N e depois N números inteiros.
 * Ao final, mostra a soma dos N números lidos.
 * Entrada				Saída
 * 3				    11
 * 5
 * 2
 * 4 */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int valor;
            int soma = 0;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine(soma);
        }
    }
}