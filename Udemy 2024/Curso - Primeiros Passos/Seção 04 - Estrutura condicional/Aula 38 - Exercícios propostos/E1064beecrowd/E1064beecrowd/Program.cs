/* Aula 38 Exercício 1064 Beecrowd - Positivos e Média
 * 
 *  Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. 
 *  Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.
 * 
 * Entrada
 * A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
 * 
 * Saída
 * O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.
 * 
 * Exemplo de Entrada	        Exemplo de Saída
 * 7                            4 valores positivos
 * -5                           7.4
 * 6
 * -3.4
 * 4.6
 * 12 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program {
        static void Main(string[] args) {
            double value1, value2, value3, value4, value5, value6;
            double calculo = 0.0;
            int total = 0;

            value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value1 > 0) {
                total++;
                calculo += value1;
            } 
            if (value2 > 0) {
                total++;
                calculo += value2;
            }
            if (value3 > 0) {
                total++;
                calculo += value3;
            }
            if (value4 > 0) {
                total++;
                calculo += value4;
            }
            if (value5 > 0) {
                total++;
                calculo += value5;
            }
            if (value6 > 0) {
                total++;
                calculo += value6;
            }

            double media = (double) calculo / total;
            Console.WriteLine(total + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}