/* Revisando URI 1012
 * Rio de Janeiro dia 07-01-2020
 * Área
 * Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
 * a) a área do triângulo que tem A por base e C por altura.
 * b) a área do círculo de raio C. (pi = 3.14159)
 * c) a área do trapézio que tem A e B por bases e C por altura.
 * d) a área do quadrado que tem lado B.
 * e) a área do retângulo que tem lados A e B.
 * Entrada:
 * O arquivo de entrada contém três valores com um dígito após o ponto decimal.
 * Saída:
 * O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem
 * correspondente e um espaço entre os dois pontos e o valor. o valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
 * Exemplo de Entrada:
 * 3.0 4.0 5.2
 * Exemplo de Saída:
 * TRIANGULO: 7.800
 * CIRCULO: 84.949
 * TRAPEZIO: 18.200
 * QUADRADO: 16.000
 * RETANGULO: 12.000 */

using System;
using System.Globalization;

namespace Revisando_URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C /2.0;
            CIRCULO = 3.14159 * C * C;
            TRAPEZIO = (A + B) / 2.0 * C;
            QUADRADO = B * B;
            RETANGULO = A * B;


            Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
