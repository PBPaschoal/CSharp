//Rio de Janeiro Dia 15-08-2021
//Múltiplos URI 1044
//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores
//lidos são múltiplos entre si.
//Entrada
//A entrada contém valores inteiros.
//Saída
//A saída deve conter uma das mensagens conforme descrito acima.
//Exemplo de Entrada:                            Exemplo de Saída:
//6 24                                           Nao sao Multiplos
//Exemplo de Entrada:                            Exemplo de Saída:
//6 25                                           Nao sao Multiplos
using System;

namespace URI1044
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] jts = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(jts[0]);
            int valor2 = int.Parse(jts[1]);

            if (valor1 % valor2 == 0 || valor2 % valor1 == 0)
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
