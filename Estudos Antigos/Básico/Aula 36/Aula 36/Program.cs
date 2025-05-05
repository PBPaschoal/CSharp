//Rio de Janeiro Dia 01-08-2021
//Aula 36 Sintaxe Opcional: operadores de atribuição cumulativa
//Problema exemplo:
//Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que exceder
//a franquia de 100 minutos custa R$ 2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar
//o valor a ser pago.
//Exemplo:
//Entrada:                                      Saída:
//22                                            Valor a pagar: R$ 50.00
//Entrada:                                      Saída:
//103                                           Valor a pagar: R$ 56.00

using System;
using System.Globalization;

namespace SintaxeOpcional_Aula_36
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
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}