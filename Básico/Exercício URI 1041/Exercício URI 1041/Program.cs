/* Exercício URI 1041
 * Dia 14-01-2021 Rio de Janeiro
 * Coordenadas de um Ponto
 * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, 
 * determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
 * Se o ponto estiver na origem, escreva a mensagem “Origem”.
 * Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
 * Entrada:
 * A entrada contem as coordenadas de um ponto.
 * Saída:
 * A saída deve apresentar o quadrante em que o ponto se encontra.
 * Exemplo de Entrada:
 * 4.5 -2.2
 * Exemplo de Saída:
 * Q4
 * Exemplo de Entrada:
 * 0.1 0.1
 * Exemplo de Saída:
 * Q1
 * Exemplo de Entrada:
 * 0.0 0.0
 * Exemplo de Saída:
 * Origem */

using System;
using System.Globalization;

namespace Exercício_URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}