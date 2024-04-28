/* Aula 52 Exercício 1079 Médias Ponderadas
 * Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. 
 * Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
 * Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o 
 * primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
 * 
 * Entrada
 * O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir 
 * contém um caso de teste com três valores com uma casa decimal cada valor.
 * 
 * Saída
 * Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
 * 
 * Exemplo de Entrada	        Exemplo de Saída
 * 3                            5.7
 * 6.5 4.3 6.2                  6.3
 * 5.1 4.2 8.1                  9.3
 * 8.0 9.0 10.0  */

using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
