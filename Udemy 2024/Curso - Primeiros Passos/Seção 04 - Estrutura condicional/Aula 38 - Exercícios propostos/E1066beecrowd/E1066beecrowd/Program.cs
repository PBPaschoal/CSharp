/* Aula 38 Exercício 1066 - Pares, Ímpares, Positivos e Negativos
 * Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores 
 * digitados foram positivos e quantos valores digitados foram negativos.

Entrada
O arquivo de entrada contém 5 valores inteiros quaisquer.

Saída
Imprima a mensagem conforme o exemplo fornecido, uma mensagem por linha, não esquecendo o final de linha após cada uma.

Exemplo de Entrada	        Exemplo de Saída
-5                          3 valor(es) par(es)
0                           2 valor(es) impar(es)
-3                          1 valor(es) positivo(s)
-4                          3 valor(es) negativo(s)
12  */

using System;
using System.Globalization;

namespace Program { 
    internal class Program {
        static void Main(string[] args) {
            int value1, value2, value3, value4, value5;
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());
            value3 = int.Parse(Console.ReadLine());
            value4 = int.Parse(Console.ReadLine());
            value5 = int.Parse(Console.ReadLine());

            // Verificando paridade e sinal dos valores
            if (value1 % 2 == 0) par++; else impar++;
            if (value2 % 2 == 0) par++; else impar++;
            if (value3 % 2 == 0) par++; else impar++;
            if (value4 % 2 == 0) par++; else impar++;
            if (value5 % 2 == 0) par++; else impar++;

            if (value1 > 0) positivo++; else if (value1 < 0) negativo++;
            if (value2 > 0) positivo++; else if (value2 < 0) negativo++;
            if (value3 > 0) positivo++; else if (value3 < 0) negativo++;
            if (value4 > 0) positivo++; else if (value4 < 0) negativo++;
            if (value5 > 0) positivo++; else if (value5 < 0) negativo++;

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}