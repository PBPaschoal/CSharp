/* Aula 38 Exercícios Beecrowd 1038 - Lanches
 * Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
 * A seguir, calcule e mostre o valor da conta a pagar.
 * 
 * Código     Especificação        Preço
 * 1	      Cachorro Quente      R$ 4.00
 * 2	      X-Salada	           R$ 4.50
 * 3	      X-Banco	           R$ 5.00
 * 4	      Torrada simples      R$ 2.00
 * 5	      Refrigerante	       R$ 1.50
 * 
 * Entrada
 * O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
 * 
 * Saída
 * O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * 3 2                              Total: R$ 10.00
 * 
 * 4 3                              Total: R$ 6.00
 * 
 * 2 3                              Total: R$ 13.50 */

using System;
using System.Globalization;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            string frase;
            frase = "Total: R$ ";
            string[] vetor = Console.ReadLine().Split(' ');

            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);

            switch (codigo)
            {
                case 1:
                    Console.WriteLine(frase + (4.0 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 2:
                    Console.WriteLine(frase + (4.5 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.WriteLine(frase + (5.0 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.WriteLine(frase + (2.0 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine(frase + (1.5 * quantidade).ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
        }
    }
}