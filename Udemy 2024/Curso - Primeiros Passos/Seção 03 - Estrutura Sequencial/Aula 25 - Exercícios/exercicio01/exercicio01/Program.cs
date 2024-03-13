/* Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
 * Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.
 * 
 * Exemplo:
 * 
 * Entrada:         Saída:
 * Maria 19	     A idade média de Maria e Joaquim é de 19.5 anos
 * Joaquim 20 */

using System;
using System.Globalization;

namespace Program {
    internal class  Program { 
        static void Main(string[] args)
        {
            string[] dados1 = Console.ReadLine().Split(' ');

            string nome1 = dados1[0];
            int idade1 = int.Parse(dados1[1]);

            string[] dados2 = Console.ReadLine().Split(' ');
            // Utilizando duas declarações de string[] dados1 e dados2 apenas para tornar mais legível o código.

            string nome2 = dados2[0];
            int idade2 = int.Parse(dados2[1]);

            double idadeMedia = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}