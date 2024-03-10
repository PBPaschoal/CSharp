/* Exercício 01
 * Fazer um programa para ler as medidas da largura e comprimento de uma terreno retangular com uma casa decimal, bem como o valor do 
 * metro quadrado do terreno com duas casas decimais.
 * Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais, conforme exemplo:
 * 
 * Entrada:          Saída:
 * 10.0              AREA = 300.00
 * 30.0              PRECO = 60000.00
 * 200.00 */

using System;
using System.Globalization;

namespace Program { 
internal class Program { 
    static void Main(string[] args) {

            // O que o exercício pede:
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * valorMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            /* Outra opção:
            Console.WriteLine("Informe a largura e depois o comprimento do terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do metro quadrado do terreno R$");
            double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * valorMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = R$" + preco.ToString("F2", CultureInfo.InvariantCulture));*/
        }
    }
}