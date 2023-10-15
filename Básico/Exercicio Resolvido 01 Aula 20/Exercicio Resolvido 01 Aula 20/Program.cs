//Rio de Janeiro dia 11-07-2021
//Revisando C#
//Exercício Resolvido 01 Aula 20
//Fazer um programa para ler as medidas da largura e comprimento de uma terreno retangular com uma casa decimal, bem como o valor
//do metro quadrado do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor
//do preço  do terreno, ambos com duas casas decimais, conforme exemplo.
//Exemplo:
//Entrada:
//10.0
//30.0
//200.00
//Saída:
//AREA = 300.00
//PRECO = 60000.00

using System;
using System.Globalization;

namespace Exercicio_Resolvido_01_Aula_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double precometroquadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * precometroquadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
