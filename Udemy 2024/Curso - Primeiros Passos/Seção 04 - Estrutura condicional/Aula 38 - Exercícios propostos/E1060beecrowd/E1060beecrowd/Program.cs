/* Aula 38 Exercício 1060 Beecrowd - Números Positivos
 * Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). 
 * A seguir, mostre a quantidade de valores positivos digitados.
 * 
 * Entrada
 * Seis valores, negativos e/ou positivos.
 * 
 * Saída
 * Imprima uma mensagem dizendo quantos valores positivos foram lidos.
 * 
 * Exemplo de Entrada	Exemplo de Saída
 * 7                    4 valores positivos
 * -5
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
           int total = 0;

            value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            value6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Sem estrutura de repetição
            if(value1 > 0) {
                total++;
            }
            if (value2 > 0) {
                total++;
            }
            if (value3 > 0) {
                total++;
            }
            if (value4 > 0) {
                total++;
            }
            if (value5 > 0) {
                total++;
            }
            if (value6 > 0) {
                total++;
            }

            Console.WriteLine(total + " valores positivos");
        }
    }
}