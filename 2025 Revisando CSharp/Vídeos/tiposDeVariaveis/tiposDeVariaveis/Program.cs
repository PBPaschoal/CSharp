using System;
using System.Globalization;

namespace Program {

    internal class Program {

        static void Main(string[] args) {
            string nome = "Bruno";
            int idade = 32;
            double altura = 1.74895;
            char letra = 'B';
            bool ehMaiordeIdade = true;

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(letra);
            Console.WriteLine(ehMaiordeIdade);
            Console.WriteLine();
            Console.WriteLine("Meu nome é " + nome);
            Console.WriteLine("Minha idade é " + idade);
            Console.WriteLine("Eu tenho " + altura.ToString("F4", CultureInfo.InvariantCulture) + " de altura.");
            Console.WriteLine("Meu nome começa com a letra " + letra);
            Console.WriteLine("Eu tenho 32 anos e sou maior de idade! " + ehMaiordeIdade);
        }
    }
}