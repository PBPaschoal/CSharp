/* Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:


Perimetro = XX.X


Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem


Area = XX.X

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal. 

Exemplo de Entrada
6.0 4.0 2.0

Exemplo de Saída
Area = 10.0

Exemplo de Entrada
6.0 4.0 2.1

Exemplo de Saída
Perimetro = 12.1 */

using System;
using System.Globalization;
class Program {
    static void Main(string[] args) {
        string[] vetor = Console.ReadLine().Split(' ');
        double A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
        double B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        double C = double.Parse(vetor[2], CultureInfo.InvariantCulture);
        double resultado = 0;
        if(A + B > C && A + C > B && B + C > A) {
            resultado = A + B + C;
            Console.WriteLine($"Perimetro = {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
        } else {
            resultado = ((A + B) * C) / 2.0;
            Console.WriteLine($"Area = {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
