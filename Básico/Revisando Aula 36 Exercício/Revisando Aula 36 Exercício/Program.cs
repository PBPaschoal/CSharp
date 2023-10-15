/* Revisando Aula 36 Exercício
 * Sintaxe opcional: Operadores de atribuição cumulativa
 * Rio de Janeiro dia 11-01-2021
 * Operadores de atribuição cumulativa:
 * a += b;     a = a + b;
 * a -= b;     a = a - b;
 * a *= b;     a = a * b;
 * a /= b;     a = a / b;
 * a %= b;     a = a % b;  
 * Problema Exemplo:
 * Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que
 * exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa
 * consumiu, daí mostrar o valor a ser pago.
 * Entrada:
 * 22
 * Saída
 * Valor a pagar: R$ 50.00
 * Entrada:
 * 103
 * Saída:
 * Valor a pagar: R$ 56.00 */

using System;
using System.Globalization;

namespace Revisando_Aula_36_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0; //Ou conta += (minutos - 100) * 2.0; que significa a mesma coisa.
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
