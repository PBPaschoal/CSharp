/* Exercício 1018 Cédulas - Beecrowd 
 * Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
 * As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
 * 
 * Entrada
 * O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
 * 
 * Saída
 * Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. 
 * Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
 * 
 * Exemplo de Entrada	                Exemplo de Saída
 * 576                                  576
 *                                      5 nota(s) de R$ 100,00
 *                                      1 nota(s) de R$ 50,00
 *                                      1 nota(s) de R$ 20,00
 *                                      0 nota(s) de R$ 10,00
 *                                      1 nota(s) de R$ 5,00
 *                                      0 nota(s) de R$ 2,00
 *                                      1 nota(s) de R$ 1,00
 *                                      
 * 11257                                11257
 *                                      112 nota(s) de R$ 100,00
 *                                      1 nota(s) de R$ 50,00
 *                                      0 nota(s) de R$ 20,00
 *                                      0 nota(s) de R$ 10,00
 *                                      1 nota(s) de R$ 5,00
 *                                      1 nota(s) de R$ 2,00
 *                                      0 nota(s) de R$ 1,00
 * 
 * 503                                  503
 *                                      5 nota(s) de R$ 100,00
 *                                      0 nota(s) de R$ 50,00
 *                                      0 nota(s) de R$ 20,00
 *                                      0 nota(s) de R$ 10,00
 *                                      0 nota(s) de R$ 5,00
 *                                      1 nota(s) de R$ 2,00
 *                                      1 nota(s) de R$ 1,00 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            // Ler o valor inteiro
            int valor = int.Parse(Console.ReadLine());

            // Imprimir o valor informado
            Console.WriteLine(valor);

            // Calcular a quantidade mínima de notas de cada tipo
            int quantidade;

            quantidade = valor / 100;
            Console.WriteLine(quantidade + " nota(s) de R$ 100,00");
            valor %= 100;

            quantidade = valor / 50;
            Console.WriteLine(quantidade + " nota(s) de R$ 50,00");
            valor %= 50;

            quantidade = valor / 20;
            Console.WriteLine(quantidade + " nota(s) de R$ 20,00");
            valor %= 20;

            quantidade = valor / 10;
            Console.WriteLine(quantidade + " nota(s) de R$ 10,00");
            valor %= 10;

            quantidade = valor / 5;
            Console.WriteLine(quantidade + " nota(s) de R$ 5,00");
            valor %= 5;

            quantidade = valor / 2;
            Console.WriteLine(quantidade + " nota(s) de R$ 2,00");
            valor %= 2;

            quantidade = valor;
            Console.WriteLine(quantidade + " nota(s) de R$ 1,00");
        }
    }
}