/* Aula 40 Estrutura repetitiva enquanto
 * Estrutura repetitiva "enquanto"
 * 
 * É uma estrutura de controle que repete um bloco de comandos enquanto uma condição for verdadeira.
 * 
 * Quando usar: quando não se sabe previamente a quantidade de repetições que será realizada.
 * 
 * Por exemplo:
 * 
 * Fazer um programa que lê números inteiros até que um zero seja lido. Ao final mostra a soma dos números lidos.
 * 
 * Entrada:     Saída:
 * 5	        11
 * 2
 * 4
 * 0 */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            int sum = 0;
            int value = int.Parse(Console.ReadLine());

            while (value != 0) {
                sum += value;
                value = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}