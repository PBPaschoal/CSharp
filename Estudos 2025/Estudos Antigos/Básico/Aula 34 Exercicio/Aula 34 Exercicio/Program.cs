//Rio de Janeiro Dia 27/07/2021
//Fórmula de Bhaskara
//Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem
//correspondente "Impossível calcular", caso haja uma divisão por 0 ou raiz de número negativo.
//Entrada:
//Leia três valores de ponto flutuante (double) A, B e C.
//Saída:
//Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5
//dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.
//Exemplos de Entrada:                                                      Exemplos de Saída:
//10.0 20.1 5.1                                                             R1 = -0.29788
//                                                                          R2 = -1.71212
//Exemplos de Entrada:                                                      Exemplos de Saída:
//0.0 20.0 5.0                                                              Impossivel calcular
//Exemplos de Entrada:                                                      Exemplos de Saída:
//10.3 203.0 5.0                                                            R1 = -0.02466
//                                                                          R2 = -19.68408

using System;
using System.Globalization;

namespace Aula_34_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            String[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
