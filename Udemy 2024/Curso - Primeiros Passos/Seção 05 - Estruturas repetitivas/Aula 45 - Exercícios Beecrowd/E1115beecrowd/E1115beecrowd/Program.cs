/* Aula 45 Exercício 1115 Quadrante - Beecrowd
 * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. 
 * Para cada ponto escrever o quadrante a que ele pertence. 
 * O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
 * 
 * Entrada
 * A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.
 * 
 * Saída
 * Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * 2 2                              primeiro
 * 3 -2                             quarto
 * -8 -1                            terceiro
 * -7 1                             segundo
 * 0 2 */

using System;

namespace Program { 
    internal class Program {
        static void Main(string[] args) {
            int X, Y;

            while (true) { 
                string[] coordenadas = Console.ReadLine().Split(' ');
                X = int.Parse(coordenadas[0]);
                Y = int.Parse(coordenadas[1]);

                if (X == 0 || Y == 0) {
                    break; // Encerrar o loop
                }
                if (X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                } else if (X < 0 && Y > 0) {
                    Console.WriteLine("segundo");
                } else if (X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                } else if (X > 0 && Y < 0) {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}