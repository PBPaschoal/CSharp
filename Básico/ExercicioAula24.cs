/*Fazer um programa para ler as medidas da base e altura de um retângulo. Em
 * seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
 * casas decimais, conforme exemplo.
 * Entrada:
 * 5.0
 * 4.0
 * Saída:
 * AREA = 20.0000
 * PERIMETRO = 18.0000
 * DIAGONAL = 6.4031
 */

using System;
using System.Globalization;

namespace RetanguloAula24
{
    class ExercicioAula24
    {
        static void Main(string[] args)
        {
            /* área = base x altura
             * perimetro = 2 x base + altura
             * diagonal = raiz quadrada de base² + altura²
             */
            double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
