/* Aula 34 Exercício - 1036 Fórmula de Bhaskara - Beecrowd
 * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
 * Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
 * caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente 
conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

Exemplos de Entrada	                Exemplos de Saída
10.0 20.1 5.1                       R1 = -0.29788
                                    R2 = -1.71212

0.0 20.0 5.0                        Impossivel calcular

10.3 203.0 5.0                      R1 = -0.02466
                                    R2 = -19.68408

10.0 3.0 5.0                        Impossivel calcular */

using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            double A, B, C, DELTA, R1, R2;

            string[] vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            DELTA = Math.Pow(B, 2.0) - 4 * A * C;

            if(A == 0 || DELTA < 0.0) {
                Console.WriteLine("Impossivel calcular");
            } else {
                R1 = (-B + Math.Sqrt(DELTA)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(DELTA)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}