/* Rio de Janeiro, dia 03-12-2020: Quinta-feira.
 * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
 * A seguir, calcule e mostre o valor da conta a pagar.
 * CODIGO   ESPECIFICAÇÃO   PREÇO
 * 1        Cachorro Quente R$ 4.00
 * 2        X-Salada        R$ 4.50
 * 3        X-Bacon         R$ 5.00
 * 4        Torrada simples R$ 2.00
 * 5        Refrigerante    R$ 1.50
 * Entrada
 * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme 
 * tabela acima.
 * Saída
 * O arquivo de saída deve conter a mensagem "Total: R$" seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 * Exemplo de Entrada:
 * 3 2
 * Exemplo de Saída:
 * Total: R$ 10.00
 * Exemplo de Entrada:
 * 4 3
 * Exemplo de Saída:
 * Total: R$ 6.00
 * Exemplo de Entrada:
 * 2 3
 * Exemplo de Saída:
 * Total: R$ 13.50 
 * Exercício URI 1038 www.urionlinejudge.com.br */

using System;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {

            double Total;
            int Escolha, Quantidade;

            Console.WriteLine("CODIGO   ESPECIFICAÇÃO       PREÇO");
            Console.WriteLine("1        Cachorro Quente     R$ 4.00");
            Console.WriteLine("2        X-Salada            R$ 4.50");
            Console.WriteLine("3        X-Bacon             R$ 5.00");
            Console.WriteLine("4        Torrada simples     R$ 2.00");
            Console.WriteLine("5        Refrigerante        R$ 1.50");
            
            string [] v = Console.ReadLine().Split(' ');
            Escolha = int.Parse(v[0]);
            Quantidade = int.Parse(v[1]);

            switch (Escolha)
            {
                case 1:
                    Total = Quantidade * 4.00;
                    Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Total = Quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Total = Quantidade * 5.00;
                    Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Total = Quantidade * 2.00;
                    Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Total = Quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
        }
    }
}
