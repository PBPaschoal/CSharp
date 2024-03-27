/* Aula 38 Exercício Beecrowd 1045 - Tipos de Triângulos
 * Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados.
 * A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem
 * adequada:
 * 
 * se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
 * se A² = B² + C², apresente a mensagem: TRIANGULO RETANGULO
 * se A² > B² + C², apresente a mensagem: TRIANGULO OBTUSANGULO
 * se A² < B² + C², apresente a mensagem: TRIANGULO ACUTANGULO
 * se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
 * se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
 * Entrada
 * A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).
 * 
 * Saída
 * Imprima todas as classificações do triângulo especificado na entrada.
 * 
 * Exemplos de Entrada	        Exemplos de Saída
 * 7.0 5.0 7.0                  TRIANGULO ACUTANGULO
 *                              TRIANGULO ISOSCELES
 * 
 * 6.0 6.0 10.0                 TRIANGULO OBTUSANGULO
 *                              TRIANGULO ISOSCELES
 * 
 * 6.0 6.0 6.0                  TRIANGULO ACUTANGULO
 *                              TRIANGULO EQUILATERO
 * 
 * 5.0 7.0 2.0                  NAO FORMA TRIANGULO
 * 
 * 6.0 8.0 10.0                 TRIANGULO RETANGULO 
 * 
 * precisa garantir que os valores de entrada sejam ordenados em ordem decrescente antes de realizar qualquer verificação.
 * As condições devem ser verificadas na ordem correta. Por exemplo, a verificação para triângulo equilátero (todos os lados iguais)
 * deve ser feita antes da verificação para triângulo isósceles (dois lados iguais).
 * A condição para triângulo retângulo (A² = B² + C²) deve vir antes da condição para triângulo obtusângulo (A² > B² + C²).
 */

using System;
using System.Globalization;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            double A, B, C;
            string[] vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            // Ordenar os valores em ordem decrescente
            if (A < B) {
                double temp = A;
                A = B;
                B = temp;
            } if (A < C) {
                double temp = A;
                A = C;
                C = temp;
            } if (B < C) {
                double temp = B;
                B = C;
                C = temp;
            }

            if (A >= (B + C)) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else if (Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0)) {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0)) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else if (Math.Pow(A, 2.0) < Math.Pow(B, 2.0) + Math.Pow(C, 2.0)) {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            } if (A == B && B == C) {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if (A == B || A == C || B == C) {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
