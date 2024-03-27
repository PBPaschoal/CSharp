/* Aula 38 Exercícios Beecrowd 1044 - Múltiplos
 * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou 
 * "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
 * 
 * Entrada
 * A entrada contém valores inteiros.
 * 
 * Saída
 * A saída deve conter uma das mensagens conforme descrito acima.
 * 
 * Exemplo de Entrada	    Exemplo de Saída
 * 6 24                     Sao Multiplos
 * 
 * 6 25                     Nao sao Multiplos */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            int A, B;
            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
