/* Aula 52 Exercício 1096 Beecrowd Sequencia IJ 2
 * Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
 * 
 * Entrada
 * Não há nenhuma entrada neste problema.
 *
 * Saída
 * Imprima a sequencia conforme exemplo abaixo
 * 
 * Exemplo de Entrada	       Exemplo de Saída
 *                             I=1 J=7
 *                             I=1 J=6
 *                             I=1 J=5
 *                             I=3 J=7
 *                             I=3 J=6
 *                             I=3 J=5
 *                             ...
 *                             I=9 J=7
 *                             I=9 J=6
  *                            I=9 J=5 */

using System;
using System.Globalization;

namespace Program { 
    
    internal class Program { 
        
        static void Main(string[] args) {
            for (int i = 1; i <= 9; i += 2)
            { // Incrementa de 2 em 2, conforme o exemplo
                for (int j = 7; j >= 5; j--)
                { // Decrementa de 1 em 1, conforme o exemplo
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}