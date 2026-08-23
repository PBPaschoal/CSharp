/* Exercício 11: Contagem de Números Pares
 * Crie um programa que solicite ao usuário inserir um número e, em seguida, conte e exiba a quantidade de números pares de 1 até o número inserido. */

using System;

namespace Program 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 011 - Contagem de Números Pares.");
            Console.Write("Informe um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int par = 0;
            for (int i = 1; i <= numero; i++) {
                if (i % 2 == 0) {
                    par++;
                }
            }
            if (par > 0) { 
                Console.WriteLine("Total de numeros pares na contagem até " + numero + " = " + par);
            } else {
                Console.WriteLine("Sem numeros pares na contagem até " + numero + " Total = 0");
            }
        }
    }
}