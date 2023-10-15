//Rio de Janeiro 14-07-2021
//Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e diagonal
//deste retângulo, com quatro casas decimais, conforme exemplo.
//Exemplo:
//Entrada:                          Saída:
//5.0                               AREA = 20.0000
//4.0                               PERIMETRO = 18.0000
//                                  DIAGONAL = 6.4031
using System;
using System.Globalization;

namespace Exercicio_Resolvido_02_Aula_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double baase, altura, area, perimetro, diagonal;

            baase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baase * altura;
            perimetro = 2 * (baase + altura);
            diagonal = Math.Sqrt(Math.Pow(baase, 2.0) + Math.Pow(altura, 2.0)); // Raiz quadrada de base e altura (base e altura ao quadrado).

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
