/* Aula 50 Exercício Beecrowd - 1071 Soma de Impares Consecutivos I
 * 
 * Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros.
 * 
 * Saída
 * O programa deve imprimir um valor inteiro. 
 * Este valor é a soma dos valores impares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.
 * 
 * Exemplo de Entrada:			Exemplo de Saída:
 * 6					        5
 * -5
 * 
 * 15					        13
 * 12
 * 
 * 12					        0
 * 12 */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int min, max, soma;
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            if (valor1 < valor2) {
                min = valor1;
                max = valor2;
            } else {
                min = valor2;
                max = valor1;
            }
            soma = 0;
            for(int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}