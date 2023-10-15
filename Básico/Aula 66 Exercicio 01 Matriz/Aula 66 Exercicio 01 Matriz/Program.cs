//Fazer um programa para ler um número inteiro N e uma matriz quadrada de ordem N contendo números inteiros.
//Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
//Exemplo:
//Entrada:
//3
//5 -3 10
//15 8 2
//7 9 -4
//Saída:
//DIAGONAL PRINCIPAL:
//5 8 -4
//QUANTIDADE DE NEGATIVOS = 2


using System;

namespace Aula_66_Exercicio_01_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int [,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i=0; i<N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i=0; i<N; i++)
            {
                for (int j=0; j<N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
            Console.ReadLine();
        }
    }
}
