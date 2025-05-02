using System;
using System.Globalization;

namespace Program {

    public class Program {

        public static void Main(string[] args) {

            //Fazer um programa para ler as medidas da largura e comprimento de um terreno
            //retangular com uma casa decimal, bem como o valor do metro quadrado do terreno
            //com duas casas decimais. Em seguida, o programa deve mostrar o valor da área
            //do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais,
            //conforme exemplo:
            //Entrada:          Saída:
            //10.0              AREA = 300.00
            //30.0              PRECO = 60000.00
            //200.00

            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valueSquareMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = width * length;
            double totalValue = valueSquareMeter * area;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}