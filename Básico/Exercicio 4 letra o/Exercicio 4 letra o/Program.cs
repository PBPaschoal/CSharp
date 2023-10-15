/* Exercicio 4 letra o. Do livro ALGORITMOS - Lógica para desenvolvimento de programação de computadores. 29º Edição.
 * José Augusto N. G. Manzano e Jayr Figueiredo de Oliveira
 * Elaborar um programa que leia quatro valores numérico inteiros (variáveis A, B, C e D).
 * Ao final, o programa deve apresentar o resultado, armazenado em memória, do produto (variável P) do primeiro com o terceiro valor, 
 * e o resultado da soma (variável S) do segundo com o quarto valor.*/

using System;

namespace Exercicio_4_letra_o
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, P, S;

            Console.Write("Primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Quarto valor: ");
            D = int.Parse(Console.ReadLine());
            P = A + C;
            S = B + D;

            Console.WriteLine("A soma do primeiro valor + o terceiro = " + P);
            Console.WriteLine("A soma do segundo valor + o quarto = " + S);
        }
    }
}
