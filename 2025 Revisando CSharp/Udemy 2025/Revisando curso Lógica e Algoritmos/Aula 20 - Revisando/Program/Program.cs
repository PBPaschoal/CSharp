//Aula 20 Exercício 01
//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
//casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais.
//Em seguida, o programa deve mostrar o valor da área do terreno, bem como o valor do preço do
//terreno, ambos com duas casas decimais, conforme exemplo.
//Entrada:
//10.0
//30.0
//200.00
//Saída:
//AREA = 300.00
//PRECO = 60000.00

using System;
using System.Globalization;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = largura * comprimento;
            double precototal = area * preco;
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precototal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}