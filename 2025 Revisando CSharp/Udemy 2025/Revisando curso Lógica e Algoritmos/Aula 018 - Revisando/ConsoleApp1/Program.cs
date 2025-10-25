//Dia 25/10/2025 Revisando
//Aula 18
//Exercício de fixação
//Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
//Entre com seu nome completo:
//Alex Green
//Quantos quartos tem na sua casa?
//3
//Entre com o preço de um produto:
//500.50
//Entre seu último nome, idade e altura (mesma linha):
//Green 21 1.73
//Saída:
//Alex Green
//3
//500.50
//Green
//21
//1.73

using System;
using System.Globalization;

public class Program {

    public static void Main(string[] args) {

        Console.WriteLine("Entre com o seu nome completo:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sau casa?");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
        string[] vet = Console.ReadLine().Split(' ');
        string ultimonome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
        Console.WriteLine(nome);
        Console.WriteLine(quantidade);
        Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(ultimonome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}