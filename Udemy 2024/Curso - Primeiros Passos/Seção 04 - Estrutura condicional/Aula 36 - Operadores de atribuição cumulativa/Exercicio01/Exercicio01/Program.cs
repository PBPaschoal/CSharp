/* Aula 36 Exercício 
 * Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone.
 * Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00.
 * Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.
 * 
 * Entrada: 		Saída:
 * 22			    Valor a pagar: R$ 50.00
 * 
 * Entrada: 		Saída:
 * 103			    Valor a pagar: R$ 56.00 */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            int minutos;

            minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100) {
                Console.WriteLine("Valor a pagar: R$ 50.00");
            } else {
                double conta = 50.0;
                conta += (minutos - 100) * 2.00;
                Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}