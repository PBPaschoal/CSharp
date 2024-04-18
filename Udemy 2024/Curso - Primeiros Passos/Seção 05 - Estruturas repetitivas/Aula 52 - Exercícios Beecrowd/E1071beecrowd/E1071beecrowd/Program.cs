/* Aula 52 Exercício Beecrowd - 1071 Soma de Impares Consecutivos I
 * Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros.
 * 
 * Saída
 * O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre os valores
 * fornecidos na entrada que deverá caber em um inteiro.
 * 
 * Exemplo de Entrada	                 Exemplo de Saída
 * 6                                     5
 * -5
 * 
 * 15                                    13
 * 12
 * 
 * 12                                    0
 * 12 */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            int X, Y, maior, menor, soma;
            soma = 0;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            if (X < Y) {
                maior = Y;
                menor = X;
            } else {
                maior = X;
                menor = Y;
            }
            for (int i = menor + 1; i < maior; i++) { 
                if(i % 2 != 0) {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}