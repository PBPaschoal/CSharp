/* Revisando Exercício URI 1035
 * Rio de Janeiro dia 11-01-2021
 * Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for 
 * maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem 
 * "Valores aceitos", senão escrever "Valores nao aceitos".
 * Entrada:
 * Quatro números inteiros A, B, C e D.
 * Saída:
 * Mostre a respectiva mensagem após a validação dos valores.
 * Exemplo de Entrada:
 * 5 6 7 8 
 * Exemplo de Saída:
 * Valores nao aceitos
 * Exemplo de Entrada:
 * 2 3 2 6
 * Exemplo de Saída:
 * Valores aceitos */


using System;

namespace Revisando_Exercício_URI_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            String[] vetor;

            vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);
            D = int.Parse(vetor[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
