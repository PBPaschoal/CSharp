/* Exercício de fixação
 * Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
 * 
 * Entre com seu nome completo:
 * Alex Green
 * Quantos quartos tem na sua casa?
 * 3
 * Entre com o preço de um produto:
 * 500.50
 * Entre seu último nome, idade e altura (mesma linha):
 * Green 21 1.73
 * 
 * Saída esperada (números reais com duas casas decimais):
 * 
 * Alex Green
 * 3
 * 500.50
 * Green
 * 21
 * 1.73 */

using System;
using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
int quarto = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] dados = Console.ReadLine().Split(' ');

string ultimoNome = dados[0];
int idade = int.Parse(dados[1]);
double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

Console.WriteLine(nomeCompleto);
Console.WriteLine(quarto);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
