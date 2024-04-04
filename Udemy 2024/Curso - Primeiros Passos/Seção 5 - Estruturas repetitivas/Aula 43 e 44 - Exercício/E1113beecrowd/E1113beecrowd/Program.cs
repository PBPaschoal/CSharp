/* Aula 43 Exercício 1113 Beecrowd - Crescente e Decrescente
 * 
 * Leia uma quantidade indeterminada de duplas de valores inteiros X e Y.
 * Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.
 * 
 * Entrada
 * A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y.
 * A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.
 * 
 * Saída
 * Para cada caso de teste imprima "Crescente", caso os valores tenham sido digitados na ordem crescente, caso contrario imprima a mensagem "Decrescente"
 * 
 * Exemplo de Entrada:		Exemplo de Saída:
 * 5 4				        Decrescente
 * 7 2 				        Decrescente
 * 3 8				        Crescente
 * 2 2 */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            string[] values = Console.ReadLine().Split(' ');
            int value1, value2;
            value1 = int.Parse(values[0]);
            value2 = int.Parse(values[1]);
            while (value1 != value2) {
                if (value1 < value2) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente");
                }
                values = Console.ReadLine().Split(' ');
                value1 = int.Parse(values[0]);
                value2 = int.Parse(values[1]);
            }
        }
    }
}