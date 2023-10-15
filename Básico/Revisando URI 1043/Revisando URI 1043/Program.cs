/* Revisando Exercício URI 1043
 * Rio de Janeiro dia 18-01-2021
 * Triângulo
 * Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do 
 * triângulo e apresente a mensagem:
 * Perimetro = xx.x
 * Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
 * Area = xx.x
 * Entrada:
 * A entrada contém três valores reais.
 * Saída:
 * O resultado deve ser apresentado com uma casa decimal.
 * Exemplo de Entrada:
 * 6.0 4.0 2.0
 * Exemplo de Saída:
 * Area = 10.0
 * Exemplo de Entrada:
 * 6.0 4.0 2.1
 * Exemplo de Saída:
 * Perimetro = 12.1 */

using System;
using System.Globalization;

namespace Revisando_URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, perimetro, area;

            string[] entrada = Console.ReadLine().Split(' ');
            a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}