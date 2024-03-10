/* Exercício 15: Números Primos no Intervalo
 * Desenvolva um programa que solicite ao usuário inserir um número e exiba todos os números primos no intervalo de 1 até o número fornecido.*/

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício 15 - Números Primos no Intervalo");
            Console.Write("Informe um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Números primos no intervalo de 1 até " + numero + ": ");

            for (int i = 2; i <= numero; i++) {
                bool ehPrimo = true;

                for (int j = 2; j <= Math.Sqrt(i); j++) {
                    if (i % j == 0) {
                        ehPrimo = false;
                        break;
                    }
                }

                if (ehPrimo) {
                    Console.Write(i + " ");
                }
            }

            /*for (int i = 2; i <= numero; i++) {
                int divisores = 0;

                for (int j = 1; j <= i; j++) {
                    if (i % j == 0) {
                        divisores++;
                    }
                }

                if (divisores == 2) {
                    Console.Write(i + " ");
                }
            }*/
        }
    }
}
