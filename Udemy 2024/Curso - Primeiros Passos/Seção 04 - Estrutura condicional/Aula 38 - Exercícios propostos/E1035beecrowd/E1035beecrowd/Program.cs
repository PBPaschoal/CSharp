/* Aula 38 Exercício Beecrowd 1035 - Teste de Seleção 1
 * Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a 
 * soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for 
 * par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".
 * 
 * Entrada
 * Quatro números inteiros A, B, C e D.
 * 
 * Saída
 * Mostre a respectiva mensagem após a validação dos valores.
 * 
 * Exemplo de Entrada	            Exemplo de Saída
 * 5 6 7 8                          Valores nao aceitos
 * 
 * 2 3 2 6                          Valores aceitos */

using System;

namespace Program { 
    internal class Program {
        static void Main(string[] args) {
            int A, B, C, D;
            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);
            D = int.Parse(vetor[3]);

            if(B > C && D > A && C + D > A + B && C >= 0 && D >= 0 && A % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            } else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}