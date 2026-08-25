/* Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como foram lidos.

Entrada
A entrada contem três números inteiros.

Saída
Imprima a saída conforme foi especificado.

Exemplo de Entrada
7 21 -14
Exemplo de Saída
-14
7
21

7
21
-14
Exemplo de Entrada
-14 21 7
Exemplo de Saída
-14
7
21

-14
21
7 */

using System;

class Program {
    static void Main(string[] args) {
        string[] vetor = Console.ReadLine().Split(' ');
        int a = int.Parse(vetor[0]);
        int b = int.Parse(vetor[1]);
        int c = int.Parse(vetor[2]);

        // 1. Se 'a' for o menor de todos
        if (a < b && a < c) {
            if (b < c) {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            } else {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        // 2. Se 'b' for o menor de todos
        else if (b < c) {
            if (a < c) {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            } else {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        // 3. Se 'c' for o menor de todos
        else {
            if (a < b) {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            } else {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }

        // Linha em branco e depois a ordem original
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}