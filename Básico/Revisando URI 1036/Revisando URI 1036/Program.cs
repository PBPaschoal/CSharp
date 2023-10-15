/* Revisando URI 1036
 * Rio de Janeiro dia 11-01-2021
 * Fórmula de Bhaskara
 * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as 
 * raízes, mostre a mensagem correspondente "impossível calcular", caso haja uma divisão por 0 ou raiz de número negativo.
 * Entrada:
 * Leia três valores de ponto flutuante (double) A, B, e C.
 * Saída:
 * Se não houver possibilidade de calcular as raízes, apresente a mensagem "impossível calcular". Caso contrário, imprima o 
 * resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o 
 * final de linha após cada mensagem.
 * Exemplo de Entrada:
 * 10.0 20.1 5.1
 * Exemplo de Saída:
 * R1 = -0.29788
 * R2 = -1.71212
 * Análise:
 * ax² + bx + c = 0
 * x = -b+- raiz de delta sobre 2a
 * delta = b² -4ac
 * Delta não pode ser negativo
 * A não pode ser zero */

using System;
using System.Globalization;

namespace Revisando_URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Delta, R1, R2;

            String[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2.0) - 4 * A * C;
            
            if (A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
