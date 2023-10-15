//Dia 11-07-2021 Rio de Janeiro
//Revisando C#
//Exercício de fixação
//Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os
//dados na tela:
//Entre com se nome completo:
//Alex Green
//Quantos quartos tem na sua casa?
//3
//Entre com o preço de um produto:
//500.50
//Entre seu último nome, idade e altura (mesma linha):
//Green 21 1.73
//Saída esperada (números reais com duas casas decimais):
//Alex Green
//3
//500.50
//Green
//21
//1.73

using System;
using System.Globalization;

namespace ExercicioFixacaoAula18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade, e altura (mesma linha):");

            string[] mlinha = Console.ReadLine().Split(' ');
            string ultimonome = mlinha[0];
            int idade2 = int.Parse(mlinha[1]);
            double altura = double.Parse(mlinha[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimonome);
            Console.WriteLine(idade2);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
