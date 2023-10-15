//Rio de Janeiro Dia 19-07-2021
//Distância Entre Dois Pontos
//Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância
//entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
//Entrada
//O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda
//linha contém dois valores de ponto flutuante x2 y2.
//Saída
//Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
//Exemplo de Entrada:                                   Exemplo de Saída:
//1.0 7.0                                               4.4721
//5.0 9.0

using System;
using System.Globalization;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, resultado;

            string[] letras = Console.ReadLine().Split(' ');

            x1 = double.Parse(letras[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(letras[1], CultureInfo.InvariantCulture);

            string[] letras2 = Console.ReadLine().Split(' ');

            x2 = double.Parse(letras2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(letras2[1], CultureInfo.InvariantCulture);

            resultado = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
