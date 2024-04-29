/* Aula 52 Exercício 1080 Beecrowd Maior e Posição
 * Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
 * 
 * Entrada
 * O arquivo de entrada contém 100 números inteiros, positivos e distintos.
 * 
 * Saída
 * Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * 2                                34565
 * 113                              4
 * 45
 * 34565
 * 6
 * ...
 * 8  */

using System;

namespace Program { 
    internal class Program {
        static void Main(String[] args) {
            int valor_inteiro, cont, posicao, maior;
            cont = 0;
            posicao = 0; 
            maior = int.MinValue; 
            do {
                valor_inteiro = int.Parse(Console.ReadLine());
                if (valor_inteiro > maior) { 
                    maior = valor_inteiro;
                    posicao = cont; 
                }
                cont++;
            } while (cont != 100);

            Console.WriteLine(maior);
            Console.WriteLine(posicao + 1);
        }
    }
}