//Rio de Janeiro Dia 19-07-2021
//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
//Entrada
//O arquivo de entrada contém três valores inteiros.
//Saída
//Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior"
//Exemplos de Entrada:                          Exemplos de Saída:
//7 14 106                                      106 eh o maior

using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, maiorXY, maior;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);

            maiorXY = (x + y + Math.Abs(x - y)) / 2;

            maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
