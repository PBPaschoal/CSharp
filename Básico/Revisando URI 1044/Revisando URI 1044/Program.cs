/* Revisando URI 1044
 * Rio de Janeiro dia 11-01-2021
 * Múltiplos
 * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
 * indicando se os valores lidos são múltiplos entre si.
 * Entrada:
 * A entrada contém valores inteiros.
 * Saída:
 * A saída deve conter uma das mensagens conforme descrito acima.
 * Exemplo de Entrada:
 * 6 24
 * Exemplo de Saída:
 * Sao Multiplos
 * Exemplo de Entrada:
 * 6 25
 * Exemplo de Saída:
 * Nao sao Multiplos */


using System;

namespace Revisando_URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
