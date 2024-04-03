/* Aula 38 Exercício 1043 Beecrowd - Triângulo
 * 
 * Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
 * 
 * Perimetro = XX.X
 * 
 * Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
 * 
 * Area = XX.X
 * 
 * Entrada
 * A entrada contém três valores reais.
 * 
 * Saída
 * O resultado deve ser apresentado com uma casa decimal.
 * 
 * Exemplo de Entrada	                Exemplo de Saída
 * 6.0 4.0 2.0                          Area = 10.0
 * 
 * 6.0 4.0 2.1                          Perimetro = 12.1 */


using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            double value1, value2, value3, perimetro, area;
            string[] values = Console.ReadLine().Split(' ');

            value1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            value2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            value3 = double.Parse(values[2], CultureInfo.InvariantCulture);

            perimetro = value1 + value2 + value3;
            area = (value1 + value2) * value3 / 2.0;

            if ((value1 + value2) > value3 && (value1 + value3) > value2 && (value2 + value3) > value1) {
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}