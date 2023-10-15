//Problema exemplo
//Fazer um programa para ler dois números inteiros positivos M e N, depois ler uma matriz de M linhas e N colunas contendo números inteiros.
//Em seguida, mostrar na tela a matriz lida conforme exemplo:
//Entrada:
//2 3 (duas linhas e três colunas)
//6 3 10 (linha 01)
//8 12 5 (linha 02)
//Saída:
//6 3 10
//8 12 5

using System;

namespace Aula_63_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);
            A = new int[M, N];

            for (int i=0; i<M; i++) // linhas
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++) // colunas
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (int i=0; i<M; i++) 
            {
                for (int j=0; j<N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
