//Rio de Janeiro Dia 14-07-2021
//Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre
//essas pessoas, com uma casa decimal, conforme exemplo.
//Exemplo:
//Entrada:                          Saída:
//Maria 19                          A idade média de Maria e Joaquim é de 19.5 anos
//Joaquim 20
using System;
using System.Globalization;

namespace Aula_25_Exercicio_Resolvido_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] vetnid;

            vetnid = Console.ReadLine().Split(' ');
            nome1 = vetnid[0];
            idade1 = int.Parse(vetnid[1]);
            vetnid = Console.ReadLine().Split(' ');
            nome2 = vetnid[0];
            idade2 = int.Parse(vetnid[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");

            Console.ReadLine();
        }
    }
}
