﻿/* Exercício URI 1052
 * Dia 21-01-2021 Rio de Janeiro
 * Mês
 * Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser apresentado como resposta o mês do ano
 * por extenso, em inglês, com a primeira letra maiúscula.
 * Entrada:
 * A entrada contém um único valor inteiro.
 * Saída:
 * Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.
 * Exemplo de Entrada:
 * 4
 * Exemplo de Saída:
 * April */


using System;

namespace Revisando_URI_1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

            }
        }
    }
}
