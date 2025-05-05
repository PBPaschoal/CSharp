//Rio de Janeiro Dia 27/07/2021
//Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.
//Exemplos:
//Entrada:                                                                Saída:
//7 3 8                                                                   MENOR = 3
//Entrada:                                                                Saída:
//5 12 5                                                                  MENOR = 5
//Entrada:                                                                Saída:
//9 9 9                                                                   MENOR = 9

using System;

namespace Aula_35_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            String[] vetNum = Console.ReadLine().Split(' ');

            n1 = int.Parse(vetNum[0]);
            n2 = int.Parse(vetNum[1]);
            n3 = int.Parse(vetNum[2]);

            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("MENOR = " + n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("MENOR = " + n2);
            }
            else
            {
                Console.WriteLine("MENOR = " + n3);
            }
            
        }
    }
}
