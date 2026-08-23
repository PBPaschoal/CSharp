/* Exercício 13: Multiplos de 3 e 5
 * Crie um programa que exiba a soma de todos os múltiplos de 3 ou 5 até um número fornecido pelo usuário. */

using System;

namespace Program { 
    internal class Program { 
    
        static void Main(string[] args) {

            Console.WriteLine("Exercício 013");
            Console.Write("Informe um número inteiro e positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= numero; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    soma += i;
                }
            }

            if (numero >= 3) {
                Console.WriteLine("A soma dos multipos de 3 ou 5 até " + numero + " é: " + soma);
            } else {
                Console.WriteLine("Você precisa informar um número inteiro positivo igual ou acima de 3 para calcular a soma dos múltiplos de 3 ou 5.");
            }
        }
    }

}