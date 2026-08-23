using System;
using System.Globalization;

namespace Program { 
    internal class Program { 
        static void Main(string[] args) {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe a primeira letra do seu nome: ");
            char letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Olá, " + nome + "!");
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Sua altura é " + altura.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Letra: " + letra);
        }
    }
}