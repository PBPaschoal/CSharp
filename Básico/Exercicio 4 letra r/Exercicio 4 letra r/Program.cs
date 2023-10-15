/* Exercicio 4 letra r.Do livro ALGORITMOS - Lógica para desenvolvimento de programação de computadores. 29º Edição.
 * Rio de Janeiro, dia 08.09.2020 às 23:37hrs
 * José Augusto N.G.Manzano e Jayr Figueiredo de Oliveira
 * Em uma eleição sindical concorreram ao cargo de presidente três candidatos (representados pelas variáveis A, B e C).
 * Durante a apuração dos votos foram computados votos nulos e em branco, além dos votos válidos para cada candidato.
 * Deve ser criado um programa de computador que faça a leitura da quantidade de votos válidos para cada candidato,
 * além de ler também a quantidade de votos nulos e em branco. Ao final, o programa deve apresentar o número total de 
 * eleitores, considerando votos válidos, nulos e em branco; o percentual correspondente de votos válidos em relação 
 * à quantidade de eleitores; o percentual correspondente de votos válidos do candidato A em relação à quantidade 
 * de eleitores; o percentual correspondente de votos válidos do candidato B em relação à quantidade de eleitores; o
 * percentual correspondente de votos válidos do candidato C em relação à quantidade de eleitores; o percentual 
 * correspondente de votos nulos em relação à quantidade de eleitores; e, por último, o percentual correspondente 
 * de votos em branco em relação à quantidade de eleitores. Todos os cálculos devem efetivamente ser armazenados 
 * em memória.
*/
using System;

namespace Exercicio_4_letra_r
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, N, Br, TV, TNB, TotalCand;
            float percTTL, perceA, perceB, perceC, perceN, perceBr;

            Console.WriteLine("Candidato A VOTOS: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Candidato B VOTOS: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Candidato C VOTOS: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("VOTOS NULOS: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("VOTOS EM BRANCO: ");
            Br = int.Parse(Console.ReadLine());

            TV = A + B + C;
            TNB = N + Br;
            TotalCand = TV + TNB;

            percTTL = (TV * 100) / TotalCand;
            perceA = (A * 100) / TotalCand;
            perceB = (B * 100) / TotalCand;
            perceC = (C * 100) / TotalCand;
            perceN = (N * 100) / TotalCand;
            perceBr = (Br * 100) / TotalCand;

            Console.WriteLine("Total de votos validos: " + TV);
            Console.WriteLine("Total de votos nulos e em brancos: " + TNB);
            Console.WriteLine("Total de eleitores: " + TotalCand);
            Console.WriteLine("Percentual do total validos: " + percTTL + "%");
            Console.WriteLine("Percentual validos de A: " + perceA + "%");
            Console.WriteLine("Percentual validos de B: " + perceB + "%");
            Console.WriteLine("Percentual validos de C: " + perceC + "%");
            Console.WriteLine("Percentual de nulos: " + perceN + "%");
            Console.WriteLine("Percentual em brancos: " + perceBr + "%");
        }
    }
}