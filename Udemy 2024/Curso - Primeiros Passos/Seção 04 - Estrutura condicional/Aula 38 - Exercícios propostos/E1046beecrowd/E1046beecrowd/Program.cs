/* Aula 38 Exercício Beecrowd 1046 - Tempo de Jogo
 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo
 * pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
 * 
 * Entrada
 * A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
 * 
 * Saída
 * Apresente a duração do jogo conforme exemplo abaixo.
 * 
 * Exemplo de Entrada	    Exemplo de Saída
 * 16 2                     O JOGO DUROU 10 HORA(S)
 * 
 * 0 0                      O JOGO DUROU 24 HORA(S)
 * 
 * 2 16                     O JOGO DUROU 14 HORA(S) */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            int inicio, fim, duracao;

            string[] vetor = Console.ReadLine().Split(' ');
            inicio = int.Parse(vetor[0]);
            fim = int.Parse(vetor[1]);

            if (inicio < fim) {
                // Caso em que o jogo ocorre no mesmo dia
                duracao = fim - inicio;
            } else {
                // Caso em que o jogo ocorre em dois dias diferentes
                duracao = 24 - inicio + fim;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
