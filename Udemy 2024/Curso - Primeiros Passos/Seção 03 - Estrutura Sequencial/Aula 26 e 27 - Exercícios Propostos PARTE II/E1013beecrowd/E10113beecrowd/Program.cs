/* Exercício 1013 O Maior - Beecrowd 
 * Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 
 * Utilize a fórmula:
 * 
 * Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para 
 * chegar no resultado esperado.
 *
 * Entrada
 * O arquivo de entrada contém três valores inteiros.
 *
 * Saída
 * Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
 *
 * Exemplos de Entrada	                Exemplos de Saída
 * 7 14 106                             106 eh o maior
 * 
 * 217 14 6                             217 eh o maior  */

using System;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            int a, b, c;
            string[] dados = Console.ReadLine().Split(' ');

            a = int.Parse(dados[0]);
            b = int.Parse(dados[1]);
            c = int.Parse(dados[2]);
            if(a > b && a > c) {
                Console.WriteLine(a + " eh o maior");
            } else if (b > c) {
                Console.WriteLine(b + " eh o maior");
            } else {
                Console.WriteLine(c + " eh o maior");
            }
        }
    }
}