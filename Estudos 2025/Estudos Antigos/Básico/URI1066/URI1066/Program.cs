//Rio de Janeiro Dia 20/02/2022
//URI 1066
//Pares, Ímpares, Positivos e Negativos
//Leia 5 valores inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores ditados foram ímpares,
//quantos valores digitados foram positivos e quantos valores digitado foram negativos.
//Entrada:
//O arquivo de entrada contém 5 valores inteiros quaisquer.
//Saída:
//Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.
//Exemplo de Entrada:                         Exemplo de Saída:
//-5                                          3 valor(es) par(es)
//0                                           2 valor(es) impar(es)
//-3                                          1 valor(es) positivo(s)
//-4                                          3 valor(es) negativo(s)
//12

using System;

namespace URI1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num% 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

            Console.ReadLine();
        }
    }
}
