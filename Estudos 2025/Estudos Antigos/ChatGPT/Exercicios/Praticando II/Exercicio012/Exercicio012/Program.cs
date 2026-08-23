/* Exercício 12: Soma de Números Ímpares
 * Desenvolva um programa que solicite ao usuário inserir um número e calcule a soma dos números ímpares de 1 até o número inserido. */

using System;

namespace Program {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercício 12 - Soma de números ímpares");
            Console.Write("Informe um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int impar = 0;
            int soma = 0;

            for (int i = 1; i <= numero; i++) { 
                if(i % 2 != 0) {
                    impar++;
                    soma += i;
                }
            }

            if (soma >= 1) { 
                Console.WriteLine("O total da soma dos numeros impares = " + soma);
            } else {
                Console.WriteLine("O número precisa ser inteiro e positivo!");
            }
        }
    }
}
