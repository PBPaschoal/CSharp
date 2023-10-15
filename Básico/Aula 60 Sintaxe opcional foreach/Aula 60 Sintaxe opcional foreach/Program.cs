//Fazer um programa para ler um valor N e depois o nome de N pessoas.
//Em seguida, mostrar os nomes lidos.
//Entrada:
//3
//Maria
//Joaquim
//Ana
//
//Saída:
//Nomes lidos:
//Maria
//Joaquim
//Ana

using System;

namespace Aula_60_Sintaxe_opcional_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadLine();
        }
    }
}
