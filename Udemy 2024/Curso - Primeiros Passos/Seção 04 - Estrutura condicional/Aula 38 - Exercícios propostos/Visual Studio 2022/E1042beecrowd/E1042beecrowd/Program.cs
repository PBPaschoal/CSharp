/* Aula 38 Exercício 1042 Beecrowd - Sort Simples
 * 
 * Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, 
 * uma linha em branco e em seguida, os valores na sequência como foram lidos.
 * 
 * Entrada
 * A entrada contem três números inteiros.
 * 
 * Saída
 * Imprima a saída conforme foi especificado.
 * 
 * Exemplo de Entrada			Exemplo de Saída
 * 7 21 -14				        -14
 * 					              7
 * 					             21
 * 
 *  				              7
 * 					             21
 * 					            -14
 * 
 * -14 21 7				        -14
 * 					              7
 * 					             21
 * 
 * 					            -14
 * 					             21
 * 					              7 */

using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, value3;
            string[] values = Console.ReadLine().Split(' ');

            // Convertendo os valores para inteiros
            value1 = int.Parse(values[0]);
            value2 = int.Parse(values[1]);
            value3 = int.Parse(values[2]);

            // Ordenando os valores
            if (value1 > value2)
            {
                int temp = value1;
                value1 = value2;
                value2 = temp;
            }
            if (value2 > value3)
            {
                int temp = value2;
                value2 = value3;
                value3 = temp;
            }
            if (value1 > value2)
            {
                int temp = value1;
                value1 = value2;
                value2 = temp;
            }

            // Exibindo os valores ordenados
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            // Exibindo os valores na sequência original
            Console.WriteLine();
            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);
        }
    }
}
