//Rio de Janeiro Dia 20-10-2021
//Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em
//seguida, os valores na sequência como foram lidos.
//
//Entrada
//A entrada contem três números inteiros.
//
//Saída
//Imprima a saída conforme foi especificado.
//Exemplo de Entrada	                                Exemplo de Saída
//7 21 -14                                              -14
//                                                      7
//                                                      21
//
//                                                      7
//                                                      21
//                                                      -14
//--
//-14 21 7                                              -14
//                                                      7
//                                                      21
//
//                                                      -14
//                                                      21
//                                                      7

using System;

namespace URI1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, bigger, middle, smaller;

            String[] vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
            z = int.Parse(vetor[2]);

             if (x < y && x < z) {
                smaller = x;
                if (y < z) {
                    middle = y;
                    bigger = z;
                }
                else {
                    middle = z;
                    bigger = y;
                }
            }
            else if (y < z) {
                smaller = y;
                if (x < z) {
                    middle = x;
                    bigger = z;
                }
                else {
                    middle = z;
                    bigger = x;
                }
            }
            else {
                smaller = z;
                if (x < y) {
                    middle = x;
                    bigger = y;
                }
                else {
                    middle = y;
                    bigger = x;
                }
            }

            Console.WriteLine(smaller);
            Console.WriteLine(middle);
            Console.WriteLine(bigger);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
