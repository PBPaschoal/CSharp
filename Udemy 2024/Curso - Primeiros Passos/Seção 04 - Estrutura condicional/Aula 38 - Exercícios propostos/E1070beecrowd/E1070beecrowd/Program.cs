/* Aula 38 Exercício 1070 Beecrowd - Seis Números Ímpares
 * Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso.
 * 
 * Entrada
 * A entrada será um valor inteiro positivo.
 * 
 * Saída
 * A saída será uma sequência de seis números ímpares.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 *  8                               9
 *                                  11
 *                                  13
 *                                  15
 *                                  17
 *                                  19 */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int X = int.Parse(Console.ReadLine());

            if(X % 2 == 0) {
                X++;
            }

            Console.WriteLine(X);
            Console.WriteLine(X + 2);
            Console.WriteLine(X + 4);
            Console.WriteLine(X + 6);
            Console.WriteLine(X + 8);
            Console.WriteLine(X + 10);
        }
    }
}