/* Rio de Janeiro, dia 03-03-2022
 * URI1070
 * Seis Números Ímpares
 * Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por 
 * linha, inclusive X ser for o caso.
 * Entrada:
 * A entrada será um valor inteiro positivo.
 * Saída:
 * A saída será um sequência de seis números ímpares.
 * Exemplo de Entrada:             Exemplo de Saída:
 * 8                               9
 *                                 11
 *                                 13
 *                                 15
 *                                 17
 *                                 19 */


using System;

namespace URI1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());

            if ( entrada % 2 == 0)
            {
                entrada = entrada + 1;
            }

            Console.WriteLine();
            Console.WriteLine(entrada);
            Console.WriteLine(entrada + 2);
            Console.WriteLine(entrada + 4);
            Console.WriteLine(entrada + 6);
            Console.WriteLine(entrada + 8);
            Console.WriteLine(entrada + 10);
        }
    }
}
