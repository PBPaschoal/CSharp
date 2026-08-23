using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 - Revisando sintaxe básica");
            Console.WriteLine("Tipos de dados");
            Console.WriteLine("Variáveis");
            Console.WriteLine("Entrada de Dados");
            Console.WriteLine("");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu sexo (M/F): ");
            char sexo = char.Parse(Console.ReadLine());

            bool maiorDeIdade = idade >= 18;

            Console.WriteLine($"\nNome: {nome}");
            Console.WriteLine($"Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Maior de idade? {(maiorDeIdade ? "Sim" : "Não")}");

        }
    }
}