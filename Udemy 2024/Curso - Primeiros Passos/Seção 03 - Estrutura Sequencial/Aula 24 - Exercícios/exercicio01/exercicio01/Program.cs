/* Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal deste 
 * retângulo, com quatro casas decimais, conforme exemplo.
 * Exemplo:
 * 
 * Entrada:             Saída:
 * 5.0                  AREA = 20.0000
 * 4.0                  PERIMETRO = 18.0000
                        DIAGONAL = 6.4031 */

using System;
using System.Globalization;

namespace Program {
    internal class  Program { 
        static void Main(string[] args) {

            double medidaBase, medidaAltura, area, perimetro,diagonal;
            medidaBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            medidaAltura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = medidaBase * medidaAltura;
            perimetro = 2 * (medidaBase + medidaAltura);
            diagonal = Math.Sqrt(Math.Pow(medidaBase, 2.0) + Math.Pow(medidaAltura, 2.0));
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}