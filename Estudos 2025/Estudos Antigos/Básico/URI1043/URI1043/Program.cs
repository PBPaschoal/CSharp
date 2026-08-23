//Rio de Janeiro dia 18/12/2021
//Triângulo
//Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do
//triângulo e apresente a mensagem:
//Perimetro = XX.X
//Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
//Area = XX.X
//Entrada
//A entrada contém três valores reais.
//Saída
//O resultado deve ser apresentado com uma casa decimal.
//Exemplo de Entrada	                    Exemplo de Saída
//6.0 4.0 2.0                               Area = 10.0
//6.0 4.0 2.1                               Perimetro = 12.1


using System;
using System.Globalization;

namespace URI1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, perimetro, area;

            String[] vetor = Console.ReadLine().Split(' ');

            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
