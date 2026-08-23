//Rio de Janeiro Dia 15-08-2021
//URI Online Judge
//Teste de Seleção 1 | 1035
//Leia 4 valores inteiros, A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se
//C e D, ambos forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores não aceitos".
//Entrada:
//Quatro números inteiros A, B, C e D.
//Saída:
//Mostre a respectiva mensagem após a validação dos valores.
//Exemplo de Entrada:                                   Exemplo de Saída:
//5 6 7 8                                               Valores nao aceitos
//Exemplo de Entrada:                                   Exemplo de Saída:
//2 3 2 6                                               Valores aceitos

using System;

namespace URI1035
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');

            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);
            int C = int.Parse(vetor[2]);
            int D = int.Parse(vetor[3]);

            if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
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