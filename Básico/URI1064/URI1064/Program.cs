/*Rio de Janeiro Dia 07-02-2022
 * URI 1064
 * Positivos e Média
 * Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os
 * valores positivos digitados, com um dígito após o ponto decimal.
 * Entrada:
 * A entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. Pelo menos um destes números será positivo.
 * Saída:
 * O primeiro valor de saída é a quantidade de valores positivos. A próxima linha deve mostrar a média dos valores positivos digitados.
 * Exemplo de Entrada:                  Exemplo de Saída:
 * 7                                    4 valores positivos
 * -5                                   7.4
 * 6
 * -3.4
 * 4.6
 * 12
 * */

using System;
using System.Globalization;

namespace URI1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            double soma = 0.0;
            if (valor1 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor1;
            }
            if (valor2 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor2;
            }
            if (valor3 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor3;
            }
            if (valor4 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor4;
            }
            if (valor5 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor5;
            }
            if (valor6 > 0.0)
            {
                cont = cont + 1;
                soma = soma + valor6;
            }
            Console.WriteLine(cont + " valores positivos");

            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
