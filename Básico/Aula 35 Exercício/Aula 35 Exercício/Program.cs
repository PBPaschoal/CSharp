/* Exercício Aula 35 Revisando
 * Rio de Janeiro dia 11-01-2021
 * Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos.
 * Em caso de empate, mostrar apenas uma vez.
 * Exemplos: 
 * Entrada:
 * 7 3 8
 * Saída:
 * MENOR = 3 */

using System;

namespace Aula_35_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;

            String[] vet = Console.ReadLine().Split(' ');
            valor1 = int.Parse(vet[0]);
            valor2 = int.Parse(vet[1]);
            valor3 = int.Parse(vet[2]);

            if (valor1 < valor2 && valor1 < valor3)
            {
                Console.WriteLine("MENOR = " + valor1);
            }
            else if (valor2 < valor3)
            {
                Console.WriteLine("MENOR = " + valor2);
            }
            else
            {
                Console.WriteLine("MENOR = " + valor3);
            }
        }
    }
}
