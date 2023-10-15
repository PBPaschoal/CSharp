//Vetores e Tabelas
//Questão: Fazer um programa para ler um número N, depois nome (apenas uma palavra), idade e altura de N pessoas,
//conforme exemplo. Depois, mostrar na tela a altura média das pessoas, e mostrar também a porcentagem de pessoas com
//menos de 16 anos.
//Exemplo:
//Entrada:
//5
//Joao 15 1.82
//Maria 16 1.60
//Teresa 14 1.58
//Carlos 21 1.65
//Paulo 17 1.78
//
//Saída:
//Altura média: 1.69
//Pessoas com menos de 16 anos: 40.0%

using System;
using System.Globalization;

namespace Aula59ExercicioResolvido03VetoresETabelas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            // Leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // Calculo da altura media das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // Porcentagem de pessoas abaixo de 16 anos
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: "
                + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}
