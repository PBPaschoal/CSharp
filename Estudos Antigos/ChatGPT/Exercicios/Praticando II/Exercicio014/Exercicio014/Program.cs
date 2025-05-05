/* Exercício 14: Média Ponderada
 * Elabore um programa que solicite ao usuário inserir três notas e os pesos correspondentes. Calcule e exiba a média ponderada das notas. */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {

            Console.WriteLine("Exercício 14: Média Ponderada");
            Console.WriteLine("Informe os valores das notas abaixo (Numero decimal)");
            double[] vetor = new double[3];
            double media = 0.0;

            for (int i = 0; i < 3; i++) {
                Console.Write("Informe a " + (i + 1) + "o nota: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < 3; i++) {
                media += vetor[i] / 3.0;
            }

            Console.WriteLine("A media das 3 notas = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}