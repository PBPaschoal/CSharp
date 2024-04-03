/* Aula 38 Exercício 1065 Beecrowd - Pares entre Cinco Números
 * Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
 * 
 * Entrada
 * O arquivo de entrada contém 5 valores inteiros quaisquer.
 * 
 * Saída
 * Imprima a mensagem conforme o exemplo fornecido, indicando a quantidade de valores pares lidos.
 * 
 * Exemplo de Entrada	        Exemplo de Saída
 * 7                            3 valores pares
 * -5
 * 6
 * -4
 * 12  */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int value1, value2, value3, value4, value5;
            int total = 0;

            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());
            value3 = int.Parse(Console.ReadLine());
            value4 = int.Parse(Console.ReadLine());
            value5 = int.Parse(Console.ReadLine());

            if(value1 % 2 == 0) {
                total++;
            }
            if (value2 % 2 == 0) {
                total++;
            }
            if (value3 % 2 == 0) {
                total++;
            }
            if (value4 % 2 == 0) {
                total++;
            }
            if (value5 % 2 == 0) {
                total++;
            }
            Console.WriteLine(total + " valores pares");
        }
    }
}