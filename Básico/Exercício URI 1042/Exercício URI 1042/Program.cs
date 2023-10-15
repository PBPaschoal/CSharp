/* Exercício URI 1042
 * Rio de Janeiro dia 17-01-2021
 * Sort simples
 * Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e
 * em seguida, os valores na sequência como foram lidos.
 * Entrada:
 * A entrada contem três números inteiros.
 * Saída:
 * Imprima a saída conforme foi especificado.
 * Exemplo de Entrada:
 * 7 21 -14
 * Exemplo de Saída:
 * -14
 * 7
 * 21
 * 
 * 7
 * 21
 * -14
 * Exemplo de Entrada:
 * -14 21 7
 * Exemplo de Saída:
 * -14
 * 7
 * 21
 * 
 * -14
 * 21
 * 7  */


using System;

namespace Exercício_URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, maior, meio, menor;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            if (x < y && x < z)
            {
                menor = x;
                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < z)
            {
                menor = y;
                if (x < z)
                {
                    meio = x;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = x;
                }
            }
            else
            {
                menor = z;
                if (x < y)
                {
                    meio = x;
                    maior = y;
                }
                else
                {
                    meio = y;
                    maior = x;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}