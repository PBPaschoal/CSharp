/* Revisando URI 1038
 * Rio de Janeiro dia 11-01-2021
 * Lanche
 * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
 * A seguir, calcule e mostre o valor da conta a pagar.
 * CODIGO    ESPECIFICAÇÃO       PREÇO
 * 1         Cachorro Quente     R$ 4.00
 * 2         X-Salada            R$ 4.50
 * 3         X-Bacon             R$ 5.00
 * 4         Torrada simples     R$ 2.00
 * 5         Refrigerante        R$ 1.50
 * Entrada:
 * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
 * Saída:
 * O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 * Exemplo de Entrada:
 * 3 2 
 * Exemplo de Saída:
 * Total: R$ 10.00 */


using System;
using System.Globalization;

namespace Revisando_Exercício_URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vetor[0]);
            int quantidade = int.Parse(vetor[1]);

            double Total;
            if(codigo == 1)
            {
                Total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                Total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                Total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                Total = quantidade * 2.0;
            }
            else
            {
                Total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
