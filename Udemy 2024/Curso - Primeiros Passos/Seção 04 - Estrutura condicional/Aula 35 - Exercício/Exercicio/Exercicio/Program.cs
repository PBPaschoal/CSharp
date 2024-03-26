/* Aula 35 - Exercício 
 * Fazer um programa para ler três números inteiros.
 * Em seguida, mostrar qual o menor dentro os três números lidos.
 * Em caso de empate, mostrar apenas uma vez.
 * 
 * Exemplos:
 * Entrada:         Saída:
 * 7 3 8            MENOR = 3
 * 
 * Entrada:         Saída:
 * 5 12 5           MENOR = 5
 * 
 * Entrada: 	    Saída:
 * 9 9 9            MENOR = 9 */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int numero1, numero2, numero3;

            string[] vetor = Console.ReadLine().Split(' ');

            numero1 = int.Parse(vetor[0]);
            numero2 = int.Parse(vetor[1]);
            numero3 = int.Parse(vetor[2]);

            if (numero1 < numero2 && numero1 < numero3) {
                Console.WriteLine("MENOR = " + numero1);
            } else if (numero2 < numero3) {
                Console.WriteLine("MENOR = " + numero2);
            } else {
                Console.WriteLine("MENOR = " + numero3);
            }
        }
    }
}