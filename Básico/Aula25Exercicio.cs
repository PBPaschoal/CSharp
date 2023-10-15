using System;
using System.Globalization;

namespace Aula25
{
    class Aula25Exercicio
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double)(idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de "
                + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

            Console.ReadLine();
        }
    }
}
