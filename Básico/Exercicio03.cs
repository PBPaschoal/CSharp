using System;
using System.Globalization;

namespace Exercicio03EntradaeSaida
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string name2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("\n\nSeu nome completo é " + name);
            Console.WriteLine("Na sua casa tem " + quartos + " quartos");
            Console.WriteLine("O preço do produto é " + produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome é " + name2);
            Console.WriteLine("A sua idade é " + idade);
            Console.WriteLine("E a sua altura é " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
