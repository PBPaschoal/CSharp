/* Revisando URI1011
 * Dia 07-01-2021 Rio de Janeiro
 * Esfera
 * Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
 * A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
 * Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), 
 * assumem que o resultado da divisão entre dois inteiros é outro inteiro.
 * Entrada:
 * O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.
 * Saída:
 * A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade.
 * O valor deverá ser apresentado com 3 casas após o ponto.
 * Exemplo de entrada:
 * 3
 * Exemplo de Saída:
 * VOLUME = 113.097 */

using System;
using System.Globalization;

namespace Revisando_URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, VOLUME;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            VOLUME = 4.0 / 3.0 * 3.14159 * R * R * R;

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}