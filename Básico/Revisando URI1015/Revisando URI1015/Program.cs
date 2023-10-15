/* Revisando URI 1015
 * Rio de Janeiro dia 07-01-2021
 * Distância Entre Dois Pontos
 * Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1, y1) e p2(x2, y2) e calcule
 * a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula.
 * Entrada:
 * O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda
 * linha contém dois valores de ponto flutuante x2 y2.
 * Saída:
 * calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
 * Exemplo de Entrada:
 * 1.0 7.0
 * Exemplo de Saída:
 * 4.4721 */


using System;
using System.Globalization;

namespace Revisando_URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            double x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
