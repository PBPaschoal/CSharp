//Faça um programa que leia N números reais e armazene-os em um vetor.
//Em seguida: 
//- Imprimir todos os elementos do vetor
//- Mostrar na tela a soma e a média dos elementos do vetor
//Exemplo:
//Entrada:
//4
//8.0 4.0 10.0 14.0
//
//Saída:
//8.0 4.0 10. 14.0
//36.00
//9.00

using System;
using System.Globalization;

namespace Aula_58_Exercicio_Resolvido_02_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i=0; i<N; i++)
            {
                Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int i=0; i<N; i++)
            {
                soma = soma + A[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
