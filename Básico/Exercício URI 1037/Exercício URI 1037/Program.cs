/* Revisando Exercício URI 1037
 * Rio de Janeiro dia 13-01-2020
 * Intervalo
 * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos 
 * ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes 
 * intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
 * O símbolo ( representa "maior que". Por exemplo:
 * [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
 * (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000
 * Entrada:
 * O arquivo de entrada contém um número com ponto flutuante qualquer.
 * Saída:
 * A saída deve ser uma mensagem conforme exemplo abaixo.
 * Exemplo de Entrada:
 * 25.01
 * Exemplo de Saída:
 * Intervalo (25,50]
 * Exemplo de Entrada:
 * 25.00
 * Exemplo de Saída:
 * Intervalo [0,25]
 * Exemplo de Entrada:
 * -25.02
 * Exemplo de Saída:
 * Fora de intervalo */

using System;
using System.Globalization;

namespace Exercício_URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada < 0.0 || entrada > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (entrada <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entrada <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (entrada <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}